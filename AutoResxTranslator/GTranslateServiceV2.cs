using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using Google.Cloud.Translation.V2;
/* 
 * AutoResxTranslator
 * by Salar Khalilzadeh
 * 
 * https://github.com/salarcode/AutoResxTranslator/
 * Mozilla Public License v2
 */
namespace AutoResxTranslator
{
	public static class GTranslateServiceV2
	{

		private static string _googleApiKey;
		private static TranslationClient _googleClient;
		public static string GoogleApiKey {
			get { return _googleApiKey; }
			set
			{
				_googleApiKey = value;
				_googleClient = null;
			} 
		}

		private static void validateApiKey()
		{
			if (string.IsNullOrEmpty(_googleApiKey))
			{
				throw new Exception("Google Apikey is not set. Please visit translation settings tab!");
			}
			if (_googleClient == null)
			{
				_googleClient = TranslationClient.CreateFromApiKey(_googleApiKey);
			}
		}
		public static string TranslateAsync(
			string text,
			string sourceLng,
			string destLng,
			string textTranslatorUrlKey
			)
		{
			validateApiKey();

			var res = _googleClient.TranslateText(text, destLng, sourceLng);
			return res.TranslatedText;
		}

		public static IEnumerable<TranslationResult> TranslateList(
			List<string> texts,
			string sourceLng,
			string destLng
			)
		{
			validateApiKey();
			var res = _googleClient.TranslateText(texts, destLng, sourceLng);
			return res;
		}

		public static bool Translate(
			string text,
			string sourceLng,
			string destLng,
			string textTranslatorUrlKey,
			out string result)
		{
			validateApiKey();
			//Call google API for Translation
			var res = _googleClient.TranslateText(text, destLng, sourceLng);
			result = res.TranslatedText;
			return true;

		}

	}
}
