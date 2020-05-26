using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using AutoResxTranslator.Definitions;
using AutoXmlTranslator;

/* 
 * AutoResxTranslator
 * by Salar Khalilzadeh
 * 
 * https://github.com/salarcode/AutoResxTranslator/
 * Mozilla Public License v2
 */

namespace AutoResxTranslator
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		private const string defaultLangugae = "en";

		private readonly Dictionary<string, string> _languages =
			new Dictionary<string, string>
			{
				{"auto", "(Detect)"},
				{"af", "Afrikaans"},
				{"sq", "Albanian"},
				{"ar", "Arabic"},
				{"hy", "Armenian"},
				{"az", "Azerbaijani"},
				{"eu", "Basque"},
				{"be", "Belarusian"},
				{"bn", "Bengali"},
				{"bg", "Bulgarian"},
				{"ca", "Catalan"},
				{"zh-CN", "Chinese (Simplified)"},
				{"zh-TW", "Chinese (Traditional)"},
				{"hr", "Croatian"},
				{"cs", "Czech"},
				{"da", "Danish"},
				{"nl", "Dutch"},
				{"en", "English"},
				{"eo", "Esperanto"},
				{"et", "Estonian"},
				{"tl", "Filipino"},
				{"fi", "Finnish"},
				{"fr", "French"},
				{"gl", "Galician"},
				{"ka", "Georgian"},
				{"de", "German"},
				{"el", "Greek"},
				{"gu", "Gujarati"},
				{"ht", "Haitian Creole"},
				{"iw", "Hebrew"},
				{"hi", "Hindi"},
				{"hu", "Hungarian"},
				{"is", "Icelandic"},
				{"id", "Indonesian"},
				{"ga", "Irish"},
				{"it", "Italian"},
				{"ja", "Japanese"},
				{"kn", "Kannada"},
				{"km", "Khmer"},
				{"ko", "Korean"},
				{"lo", "Lao"},
				{"la", "Latin"},
				{"lv", "Latvian"},
				{"lt", "Lithuanian"},
				{"mk", "Macedonian"},
				{"ms", "Malay"},
				{"mt", "Maltese"},
				{"no", "Norwegian"},
				{"fa", "Persian"},
				{"pl", "Polish"},
				{"pt", "Portuguese"},
				{"ro", "Romanian"},
				{"ru", "Russian"},
				{"sr", "Serbian"},
				{"sk", "Slovak"},
				{"sl", "Slovenian"},
				{"es", "Spanish"},
				{"sw", "Swahili"},
				{"sv", "Swedish"},
				{"ta", "Tamil"},
				{"te", "Telugu"},
				{"th", "Thai"},
				{"tr", "Turkish"},
				{"uk", "Ukrainian"},
				{"ur", "Urdu"},
				{"vi", "Vietnamese"},
				{"cy", "Welsh"},
				{"yi", "Yiddish"}
			};

		ServiceTypeEnum ServiceType
		{
			get
			{
				if (rbtnGoogleTranslateService.Checked)
					return ServiceTypeEnum.Google;
				return ServiceTypeEnum.Microsoft;
			}
		}

		void FillComboBoxes()
		{
			cmbSrc.DisplayMember = "Value";
			cmbSrc.ValueMember = "Key";

			cmbDesc.DisplayMember = "Value";
			cmbDesc.ValueMember = "Key";
			lstResxLanguages.Items.Clear();

			for (int index = 0; index < _languages.Count; index++)
			{
				var item = _languages.ElementAt(index);
				cmbSrc.Items.Add(item);
				if (item.Key == "auto")
					continue;

				cmbDesc.Items.Add(item);
				cmbSourceResxLng.Items.Add(item);
				lstResxLanguages.Items.Add(item.Key, item.Value, -1);

				if (item.Key == defaultLangugae)
				{
					cmbSrc.SelectedIndex = index;
					cmbSourceResxLng.SelectedIndex = cmbDesc.SelectedIndex = index-1;

					cmbDesc.Text = cmbDesc.Text = item.Value;
				}

			}
			
		}

		void SetResult(string result)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new Action<string>(SetResult), result);
				return;
			}
			else
			{
				txtDesc.Text = result;
			}
		}

		void IsBusy(bool isbusy)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new Action<bool>(IsBusy), isbusy);
				return;
			}
			else
			{
				tabMain.Enabled = !isbusy;
			}
		}


		string ReadLanguageName(string fileName, string fileEnding = ".resx")
		{
			try
			{
				fileName = Path.GetFileName(fileName);
				var match = Regex.Match(fileName, @".+\.(?<lng>.+)\" + fileEnding);
				var language = match.Groups["lng"].Value;
				var culture = new CultureInfo(language);
				return language;
			}
			catch (Exception)
			{
				return "en";
			}
		}

		string ReadLanguageFilename(string fileName)
		{
			try
			{
				fileName = Path.GetFileName(fileName);
				var match = Regex.Match(fileName, @"(?<file>.+)\.(?<lng>.+)\.resx");
				var file = match.Groups["file"].Value;
				if (string.IsNullOrWhiteSpace(file))
				{
					file = Path.GetFileNameWithoutExtension(fileName);
				}
				return file;
			}
			catch (Exception)
			{
				return "res";
			}
		}



		bool ValidateResxTranslate()
		{
			string errors = "";

			if (!File.Exists(txtSourceResx.Text) 
				&& !subDirectoriesIncluded.Checked)
				errors += "Please select source ResX file.\n";
			if (cmbSourceResxLng.SelectedIndex == -1)
				errors += "Please select source ResX file's language.\n";
			if (!Directory.Exists(txtOutputDir.Text))
				errors += "Please select output directory.\n";

			bool anychecked = lstResxLanguages.Items.Cast<ListViewItem>().Any(i => i.Checked);

			if (!anychecked)
			{
				errors += "At least one output language should be selected.\n";
			}

			if (errors.Length > 0)
			{
				MessageBox.Show(errors, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}


		void TranslateResxFiles(string fileName)
		{
			var srcLng = ((KeyValuePair<string, string>)cmbSourceResxLng.SelectedItem).Key;
			var destLanguages = new List<string>();
			foreach (ListViewItem item in lstResxLanguages.Items)
			{
				if (!item.Checked)
					continue;
				if (item.Name == srcLng)
					continue;
				destLanguages.Add(item.Name);
			}
			if (destLanguages.Count == 0)
			{
				MessageBox.Show("The source and the destination languages can not be the same.", "", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			var translationOptions = new TranslationOptions
			{
				ServiceType = ServiceType,
				SubscriptionKey = ServiceType == ServiceTypeEnum.Google ? googleApiKey.Text: txtMsTranslationKey.Text,
				MsSubscriptionRegion = txtMsTranslationRegion.Text
			};


			IsBusy(true);
			new Action<string, string, TranslationOptions, List<string>, string, ResxProgressCallback>(TranslateMultiSourceResxFilesAsync).BeginInvoke(
				fileName,
				srcLng,
				translationOptions,
				destLanguages,
				txtOutputDir.Text,
				ResxWorkingProgress,
				(x) => IsBusy(false),
				null);
		}

		private delegate void ResxProgressCallback(int max, int pos, string fileName, string status);

		void TranslateMultiSourceResxFilesAsync(
			string sourceResx,
			string sourceLng,
			TranslationOptions translationOptions,
			List<string> desLanguages, string destDir,
			ResxProgressCallback progress)
		{
			int max = 0;
			int pos = 0;
			string status = "";
			if (subDirectoriesIncluded.Checked)
			{
				var searchOption = subDirectoriesIncluded.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
				var srcLngForFile = "." + sourceLng + ".resx";
				List<string> files = Directory.GetFiles(destDir, "*.*", searchOption)
					.Where(x => x.Contains(srcLngForFile))
					.ToList();
				max = files.Count;
				if (max < 1)
				{
					status = "No files found from path: " + destDir;
					progress.BeginInvoke(max, pos, null, status, null, null);
				}
				foreach (var file in files)
				{
					string fileName = Path.GetFileName(file);
					status = "Translating file: " + fileName;
					pos += 1;
					progress.BeginInvoke(max, pos, status, fileName, null, null);
					var targetDir = Path.GetDirectoryName(file);
					TranslateResxFilesListAsync(file, sourceLng, translationOptions, desLanguages, targetDir, progress);
				}
			}
			else
			{
				TranslateResxFilesListAsync(sourceResx, sourceLng, translationOptions, desLanguages, destDir, progress);
			}
		}


		void TranslateResxFilesListAsync(
			string sourceResx,
			string sourceLng,
			TranslationOptions translationOptions,
			List<string> desLanguages, string destDir,
			ResxProgressCallback progress)
		{
			int max = 0;
			int pos = 0;
			int trycount = 0;
			string status = "";
			bool hasErrors = false;

			var sourceResxFilename = ReadLanguageFilename(sourceResx);
			var errorLogFilename = sourceResxFilename + ".errors.log";
			var errorLogFile = Path.Combine(destDir, errorLogFilename);

			var valuesToTranslate = getOriginalTranslationTexts(sourceResx);

			foreach (var destLng in desLanguages)
			{
				var fileName = Path.GetFileName(sourceResx);
				var destFile = Path.Combine(destDir, sourceResxFilename + "." + destLng + ".resx");
				var doc = new XmlDocument();
				doc.Load(sourceResx);
				var dataList = ResxFileOperations.ReadResxData(doc);
				max = dataList.Count;

				var values = valuesToTranslate.Select(x => x.Value).ToList();
				var translations = GTranslateServiceV2.TranslateList(values, sourceLng, destLng).ToList();

				pos = 0;
				status = "Translating language: " + destLng;
				progress.BeginInvoke(max, pos, fileName, status, null, null);

				try
				{
					for (var index = 0; index < dataList.Count; index++)
					{
						var node = dataList[index];
						status = "Translating language: " + destLng;
						pos += 1;
						progress.BeginInvoke(max, pos, fileName, status, null, null);

						var valueNode = ResxFileOperations.GetDataValueNode(node);
						if (valueNode == null) continue;

						var orgText = valueNode.InnerText;
						if (string.IsNullOrWhiteSpace(orgText))
							continue;

						valueNode.InnerText = translations[index].TranslatedText;
					}
				}
				finally
				{
					doc.Save(destFile);
				}
			}

			if (hasErrors)
			{
				status = "Translation finished. Errors are logged in to '" + errorLogFilename + "'.";
			}
			else
			{
				status = "Translation finished.";
			}
			progress.BeginInvoke(max, pos, null, status, null, null);
		}

		private static List<KeyValuePair<string, string>> getOriginalTranslationTexts(string sourceResx)
		{
			var doc = new XmlDocument();
			doc.Load(sourceResx);
			var dataList = ResxFileOperations.ReadResxData(doc);
			var translations = new List<KeyValuePair<string, string>>();
			foreach (var node in dataList)
			{
				var key = ResxFileOperations.GetDataKeyName(node);
				var valueNode = ResxFileOperations.GetDataValueNode(node);
				if (valueNode == null) continue;

				var orgText = valueNode.InnerText;
				if (string.IsNullOrWhiteSpace(orgText))
					continue;

				translations.Add(new KeyValuePair<string, string>(key, orgText));
			}
			return translations;
		}

		void ResxWorkingProgress(int max, int pos, string fileName, string status)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new ResxProgressCallback(ResxWorkingProgress), max, pos, fileName, status);
				return;
			}
			else
			{
				barResxProgress.Minimum = 0;
				barResxProgress.Maximum = max;
				barResxProgress.Value = pos;
				lblResxTranslateStatus.Text = $"{fileName}, processing {max:00}/{pos:00}:" + status;
			}
		}


		void ImportExcel()
		{
			var sheetName = cmbExcelSheets.Text;
			var excelFile = txtExcelFile.Text;
			var resxFile = txtExcelResx.Text;
			var sheetKeyColumn = cmbExcelKey.Text;
			var sheetTranslation = cmbExcelTranslation.Text;
			var create = chkExcelCreateAbsent.Checked;

			IsBusy(true);
			new Action<string, string, string, string, string, bool>(ImportExcel).BeginInvoke(
				excelFile,
				resxFile,
				sheetName,
				sheetKeyColumn,
				sheetTranslation,
				create,
				(x) => IsBusy(false),
				null);
		}

		private void ImportExcel(string excelFile, string resxFile, string sheetName, string sheetKeyColumn,
			string sheetTranslation, bool create)
		{
			var doc = new XmlDocument();
			doc.Load(resxFile);
			var dataList = ResxFileOperations.ReadResxData(doc);

			var excelLanguages = ResxExcel.ReadExcelLanguage(excelFile, sheetName, sheetKeyColumn, sheetTranslation);
			foreach (var lngPair in excelLanguages)
			{
				var node = dataList.FirstOrDefault(x => ResxFileOperations.GetDataKeyName(x) == lngPair.Key);
				if (node != null)
				{
					ResxFileOperations.SetDataValue(doc, node, lngPair.Value);
				}
				else
				{
					ResxFileOperations.AddLanguageNode(doc, lngPair.Key, lngPair.Value);
				}
			}
			doc.PreserveWhitespace = false;
			var writer = new XmlTextWriter(resxFile, Encoding.UTF8)
			{
				Formatting = Formatting.Indented
			};
			doc.Save(writer);
			writer.Close();
		}

		bool IsGoogleTranslatorLoaded()
		{
			if (webBrowser.Document != null &&
				(webBrowser.ReadyState == WebBrowserReadyState.Loaded ||
				 webBrowser.ReadyState == WebBrowserReadyState.Complete))
			{
				return true;
			}
			return false;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			FillComboBoxes();
			tabMain.TabPages.Remove(tabBrowser);
		}

		private async void btnTranslate_ClickAsync(object sender, EventArgs e)
		{

			if (cmbDesc.SelectedIndex == -1 || cmbSrc.SelectedIndex == -1)
			{
				MessageBox.Show("Please select source and destination languages correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtSrc.Text.Length == 0)
			{
				MessageBox.Show("The text body can not be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var lngSrc = ((KeyValuePair<string, string>)cmbSrc.SelectedItem).Key;
			var lngDest = ((KeyValuePair<string, string>)cmbDesc.SelectedItem).Key;
			var text = txtSrc.Text;

			var translationOptions = new TranslationOptions
			{
				ServiceType = ServiceType,
				SubscriptionKey = ServiceType == ServiceTypeEnum.Google ? googleApiKey.Text : txtMsTranslationKey.Text,
				MsSubscriptionRegion = txtMsTranslationRegion.Text
			};



			IsBusy(true);

			if (ServiceType == ServiceTypeEnum.Google)
			{
				// There is no longer a key to validate
				var textTranslatorUrlKey = "";

				GTranslateService.TranslateAsync(
				text, lngSrc, lngDest, textTranslatorUrlKey,
				(success, result) =>
				{
					SetResult(result);
					IsBusy(false);
				});
			}
			else
			{
				var translationResult = await MsTranslateService.TranslateAsync(text, lngSrc, lngDest, translationOptions.SubscriptionKey, txtMsTranslationRegion.Text);

				if (translationResult.Success)
				{
					SetResult(translationResult.Result);
				}
				else
				{
					if (!string.IsNullOrEmpty(translationResult.Result))
						SetResult(translationResult.Result);
					else
						SetResult("Translation Failed!");
				}

				IsBusy(false);
			}
		}

		private void btnSelectResxSource_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.Filter = "ResourceX File|*.resx";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				txtSourceResx.Text = dlg.FileName;
				if (txtOutputDir.Text.Length == 0)
				{
					txtOutputDir.Text = Path.GetDirectoryName(txtSourceResx.Text);
				}

				var lng = ReadLanguageName(txtSourceResx.Text);
				var key = _languages.FirstOrDefault(x => string.Compare(x.Key, lng, StringComparison.InvariantCultureIgnoreCase) == 0);
				if (key.Key != null)
					cmbSourceResxLng.SelectedItem = key;
				else
				{
					lng = "en";
					key = _languages.FirstOrDefault(x => string.Compare(x.Key, lng, StringComparison.InvariantCultureIgnoreCase) == 0);
					if (key.Key != null)
						cmbSourceResxLng.SelectedItem = key;
				}
			}
		}

		private void btnSelectXmlSource_Click(object sender, EventArgs e)
		{
			const string fileEnding = ".xml";
			var dlg = new OpenFileDialog();
			dlg.Filter = "Xml File|*" + fileEnding;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				txtSourceResx.Text = dlg.FileName;
				if (txtOutputDir.Text.Length == 0)
				{
					txtOutputDir.Text = Path.GetDirectoryName(txtSourceResx.Text);
				}

				var lng = ReadLanguageName(txtSourceResx.Text, fileEnding);
				var key = _languages.FirstOrDefault(x => string.Compare(x.Key, lng, StringComparison.InvariantCultureIgnoreCase) == 0);
				if (key.Key != null)
					cmbSourceResxLng.SelectedItem = key;
				else
				{
					lng = "en";
					key = _languages.FirstOrDefault(x => string.Compare(x.Key, lng, StringComparison.InvariantCultureIgnoreCase) == 0);
					if (key.Key != null)
						cmbSourceResxLng.SelectedItem = key;
				}
			}
		}

		private void btnSelectOutputDir_Click(object sender, EventArgs e)
		{
			var dlg = new FolderBrowserDialog();
			dlg.ShowNewFolderButton = true;
			dlg.RootFolder = Environment.SpecialFolder.MyComputer;
			if (txtOutputDir.Text.Length > 0)
			{
				dlg.SelectedPath = txtOutputDir.Text;
			}
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				txtOutputDir.Text = dlg.SelectedPath;
			}
		}


		private void btnStartResxTranslate_Click(object sender, EventArgs e)
		{
			translateAFile(txtSourceResx.Text);
		}

		private void translateAFile(string fileNmae)
		{
			if (!ValidateResxTranslate())
				return;
			if (!IsGoogleTranslatorLoaded())
			{
				MessageBox.Show("Google Translator is not loaded.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			TranslateResxFiles(fileNmae);
		}

		private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using (var frm = new frmAbout())
			{
				frm.ShowDialog();
			}
		}

		private void btnOpenExcel_Click(object sender, EventArgs e)
		{
			if (!File.Exists(txtExcelFile.Text))
			{
				MessageBox.Show("Please select an excel file.", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var excel = ResxExcel.ReadExcel(txtExcelFile.Text);
			if (excel == null)
			{
				MessageBox.Show("Failed to read excel file", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			cmbExcelSheets.DataSource = excel.SheetNames;
			cmbExcelKey.DataSource = excel.SheetColumns;
			cmbExcelTranslation.DataSource = excel.SheetColumns;
			if (Array.IndexOf(excel.SheetColumns, "Name") != -1)
			{
				cmbExcelKey.SelectedValue = "Name";
			}
			btnImportExcel.Enabled = true;
		}

		private void btnSelectExcel_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog
			{
				Filter = "Excel File|*.xls;xlsx"
			};
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				txtExcelFile.Text = dlg.FileName;
			}
		}

		private void btnExcelResx_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog
			{
				Filter = "ResourceX File|*.resx"
			};
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				txtExcelResx.Text = dlg.FileName;
			}
		}

		private void cmbExcelSheets_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtExcelFile.Text))
				return;
			if (!File.Exists(txtExcelFile.Text))
			{
				MessageBox.Show("Please select an excel file.", "Select Resx", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (cmbExcelSheets.SelectedIndex != -1)
			{
				var cols = ResxExcel.GetExcelSheetColumns(txtExcelFile.Text, cmbExcelSheets.Text);
				cmbExcelKey.DataSource = cols;
				var cols2 = ResxExcel.GetExcelSheetColumns(txtExcelFile.Text, cmbExcelSheets.Text);
				cmbExcelTranslation.DataSource = cols2;
				if (Array.IndexOf(cols, "Name") != -1)
				{
					cmbExcelKey.Text = "Name";
				}
			}
		}

		private void btnImportExcel_Click(object sender, EventArgs e)
		{
			if (!File.Exists(txtExcelResx.Text))
			{
				MessageBox.Show("Please select ResX file.", "Select Resx", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!File.Exists(txtExcelFile.Text))
			{
				MessageBox.Show("Please select an excel file.", "Select Resx", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (cmbExcelSheets.Items.Count == 0)
			{
				MessageBox.Show("Please open excel file and select key and translation columns.", "Open Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (cmbExcelKey.SelectedIndex == -1 || cmbExcelSheets.SelectedIndex == -1 || cmbExcelTranslation.SelectedIndex == -1)
			{
				MessageBox.Show("Please select excel columns.", "Select Columns", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ImportExcel();
		}

		private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			var doc = webBrowser.Document;
			if (doc == null)
				return;
			foreach (HtmlElement imgElemt in doc.Images)
			{
				imgElemt.SetAttribute("src", "");
			}
		}

		private void RbtnMsTranslateService_CheckedChanged(object sender, EventArgs e)
		{
			txtMsTranslationKey.Enabled = rbtnMsTranslateService.Checked;
			txtMsTranslationRegion.Enabled = rbtnMsTranslateService.Checked;
			googleApiKey.Enabled = !rbtnMsTranslateService.Checked;
		}
		
		private void label17_Click(object sender, EventArgs e)
		{

		}

		private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabMain.SelectedIndex)
			{
				case 0:
					this.tabResx.Controls.Add(this.lstResxLanguages);
					this.tabResx.Controls.Add(this.lblResxTranslateStatus);
					this.tabResx.Controls.Add(this.btnStartResxTranslate);
					this.tabResx.Controls.Add(this.barResxProgress);
					this.tabResx.Controls.Add(this.label6);
					this.tabResx.Controls.Add(this.btnSelectOutputDir);
					this.tabResx.Controls.Add(this.txtOutputDir);
					this.tabResx.Controls.Add(this.label5);
					this.tabResx.Controls.Add(this.btnSelectResxSource);
					this.tabResx.Controls.Add(this.cmbSourceResxLng);
					this.tabResx.Controls.Add(this.txtSourceResx);
					this.tabResx.Controls.Add(this.label4);
					break;
				case 1:
					this.tabXml.Controls.Add(this.lstResxLanguages);
					this.tabXml.Controls.Add(this.lblResxTranslateStatus);
					this.tabXml.Controls.Add(this.btnStartXmlTranlate);
					this.tabXml.Controls.Add(this.barResxProgress);
					this.tabXml.Controls.Add(this.label15);
					this.tabXml.Controls.Add(this.btnSelectOutputDir);
					this.tabXml.Controls.Add(this.txtOutputDir);
					this.tabXml.Controls.Add(this.label16);
					this.tabXml.Controls.Add(this.btnSelectXmlSource);
					this.tabXml.Controls.Add(this.cmbSourceResxLng);
					this.tabXml.Controls.Add(this.txtSourceResx);
					this.tabXml.Controls.Add(this.label17);
					break;
			}
		}
		private void subDirectoriesIncluded_Click(object sender, EventArgs e)
		{
			btnSelectResxSource.Enabled = !subDirectoriesIncluded.Checked;
			txtSourceResx.Enabled = !subDirectoriesIncluded.Checked;
		}

		private void googleApiKey_TextChanged(object sender, EventArgs e)
		{
			GTranslateServiceV2.GoogleApiKey = googleApiKey.Text;
		}

		private void btnStartXmlTranlate_Click(object sender, EventArgs e)
		{
			if (!ValidateXmlTranslate())
				return;
			if (!IsGoogleTranslatorLoaded())
			{
				MessageBox.Show("Google Translator is not loaded.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			TranslateXmlFiles();
		}

		bool ValidateXmlTranslate()
		{
			string errors = "";

			if (!File.Exists(txtSourceResx.Text))
				errors += "Please select source XML file.\n";
			if (cmbSourceResxLng.SelectedIndex == -1)
				errors += "Please select source XML file's language.\n";
			if (!Directory.Exists(txtOutputDir.Text))
				errors += "Please select output directory.\n";

			bool anychecked = false;
			foreach (ListViewItem item in lstResxLanguages.Items)
			{
				if (item.Checked)
				{
					anychecked = true;
					break;
				}
			}
			if (!anychecked)
			{
				errors += "At least one output language should be selected.\n";
			}

			if (errors.Length > 0)
			{
				MessageBox.Show(errors, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		void TranslateXmlFiles()
		{
			var srcLng = ((KeyValuePair<string, string>)cmbSourceResxLng.SelectedItem).Key;
			var destLanguages = new List<string>();
			foreach (ListViewItem item in lstResxLanguages.Items)
			{
				if (!item.Checked)
					continue;
				if (item.Name == srcLng)
					continue;
				destLanguages.Add(item.Name);
			}
			if (destLanguages.Count == 0)
			{
				MessageBox.Show("The source and the destination languages can not be the same.", "", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			var translationOptions = new TranslationOptions
			{
				ServiceType = ServiceType,
				SubscriptionKey = ServiceType == ServiceTypeEnum.Google ? googleApiKey.Text : txtMsTranslationKey.Text,
				MsSubscriptionRegion = txtMsTranslationRegion.Text
			};

			IsBusy(true);
			new Action<string, string, TranslationOptions, List<string>, string,
				ResxProgressCallback>(TranslateXmlFilesAsync).BeginInvoke(
				txtSourceResx.Text,
				srcLng,
				translationOptions,
				destLanguages,
				txtOutputDir.Text,
				ResxWorkingProgress,
				(x) => IsBusy(false),
				null);
		}

		async void TranslateXmlFilesAsync(
		string sourceResx,
		string sourceLng,
		TranslationOptions translationOptions,
		List<string> desLanguages, string destDir,
		ResxProgressCallback progress)
		{
			int max = 0;
			int pos = 0;
			int trycount = 0;
			string status = "";
			bool hasErrors = false;

			var sourceXmlFilename = ReadLanguageFilename(sourceResx);
			var errorLogFilename = sourceXmlFilename + ".errors.log";
			var errorLogFile = Path.Combine(destDir, errorLogFilename);

			foreach (var destLng in desLanguages)
			{
				var destFile = Path.Combine(destDir, sourceXmlFilename + "-" + destLng + ".xml");
				var doc = new XmlDocument();
				doc.Load(sourceResx);
				List<XmlNode> dataListTarget = null;
				if (File.Exists(destFile))
				{
					var docTarget = new XmlDocument();
					docTarget.Load(destFile);
					dataListTarget = XmlTranslator.ReadXmlData(docTarget);
				}

				XmlTranslator.SetCulture(doc, destLng);
				var dataList = XmlTranslator.ReadXmlData(doc);
				
				max = dataList.Count;

				pos = 0;
				status = "Translating language: " + destLng;
				progress.BeginInvoke(max, pos, status, null, null, null);
				GTranslateServiceV3 googleTranslator = new GTranslateServiceV3(translationOptions.SubscriptionKey);
				
				try
				{

					foreach (var node in dataList)
					{
						status = "Translating language: " + destLng;
						pos += 1;
						progress.BeginInvoke(max, pos, status, null, null, null);


						var valueNode = node;
						if (valueNode == null) continue;

						var orgText = XmlTranslator.GetDataValue(valueNode, dataListTarget, out bool asInnerText, out bool alreadyTranslated);
						if (string.IsNullOrWhiteSpace(orgText))
							continue;

						string translated = alreadyTranslated ? orgText: string.Empty;
						bool success = alreadyTranslated;

						if (!alreadyTranslated && translationOptions.ServiceType == ServiceTypeEnum.Google)
						{
							trycount = 0;
							do
							{
								try
								{
									success = googleTranslator.Translate(orgText, sourceLng, destLng, translationOptions.SubscriptionKey, out translated);
								}
								catch (Exception)
								{
									success = false;
								}
								trycount++;

								if (!success)
								{
									var key = XmlTranslator.GetDataKeyName(node);
									status = "Translating language: " + destLng + " , key '" + key + "' failed to translate in try " + trycount;
									progress.BeginInvoke(max, pos, status, null, null, null);
								}

							} while (success == false && trycount <= 2);

						}
						else if (!alreadyTranslated &&  translationOptions.ServiceType == ServiceTypeEnum.Microsoft)
						{
							var translationResult = await MsTranslateService.TranslateAsync(orgText, sourceLng, destLng,
								translationOptions.SubscriptionKey, translationOptions.MsSubscriptionRegion);

							if (translationResult.Success)
							{
								success = true;
								translated = translationResult.Result;
							}
						}

						if (success)
						{
							XmlTranslator.SetDataValue(doc, valueNode, translated, asInnerText);
						}
						else
						{
							hasErrors = true;
							var key = XmlTranslator.GetDataKeyName(node);
							try
							{
								string message = "\r\nKey '" + key + "' translation to language '" + destLng + "' failed.";
								File.AppendAllText(errorLogFile, message);
							}
							catch
							{
							}
						}
					}
				}
				finally
				{
					// now save the file
					doc.Save(destFile);
				}
			}

			if (hasErrors)
			{
				status = "Translation finished. Errors are logged in to '" + errorLogFilename + "'.";
			}
			else
			{
				status = "Translation finished.";
			}


			progress.BeginInvoke(max, pos, status, null, null, null);

		}
	}
}
