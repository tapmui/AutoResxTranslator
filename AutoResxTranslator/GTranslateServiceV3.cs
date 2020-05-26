using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

/* 
 * AutoResxTranslator
 * by Salar Khalilzadeh
 * 
 * https://github.com/salarcode/AutoResxTranslator/
 * Mozilla Public License v2
 */
namespace AutoResxTranslator
{
	public class GTranslateServiceV3
	{
		private const string RequestUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:70.0) Gecko/20100101 Firefox/70.0";
		private const string RequestGoogleTranslatorUrl = "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&hl=en&dt=t&dt=bd&dj=1&source=icon&tk=467103.467103&q={2}";


		TranslationClient client;


		public GTranslateServiceV3(string textTranslatorUrlKey) {
			client = TranslationClient.CreateFromApiKey(textTranslatorUrlKey);
		}

		public delegate void TranslateCallBack(bool succeed, string result);
		public void TranslateAsync(
			string text,
			string sourceLng,
			string destLng,
			string textTranslatorUrlKey,
			TranslateCallBack callBack)
		{
			//var request = CreateWebRequest(text, sourceLng, destLng, textTranslatorUrlKey);
			//request.BeginGetResponse(
			//	TranslateRequestCallBack,
			//	new KeyValuePair<WebRequest, TranslateCallBack>(request, callBack));
		}

		public bool Translate(
			string text,
			string sourceLng,
			string destLng,
			string textTranslatorUrlKey,
			out string result)
		{
			TranslationResult googleResult = client.TranslateText(text, destLng, sourceLng);
			result = googleResult.TranslatedText;
			return true;
		}


	}
}
