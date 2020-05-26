using System.Collections.Generic;
using System.Linq;
using System.Xml;

/* 
 * AutoResxTranslator
 * by Salar Khalilzadeh
 * 
 * https://github.com/salarcode/AutoResxTranslator/
 * Mozilla Public License v2
 */
namespace AutoXmlTranslator
{
	public static class XmlTranslator
	{
		public static List<XmlNode> ReadXmlData(XmlDocument doc)
		{
			var root = doc.SelectSingleNode("localizationDictionary");
			var texts = root.SelectSingleNode("texts");
			var dataList = new List<XmlNode>();
			foreach (XmlNode node in texts.ChildNodes)
			{
				if (node.NodeType != XmlNodeType.Element)
					continue;
				if (node.Name != "text")
					continue;
				dataList.Add(node);
			}

			return dataList;
		}

		public static void SetCulture(XmlDocument doc, string culture)
		{
			var root = doc.SelectSingleNode("localizationDictionary");
			root.Attributes["culture"].Value = culture;
		}
		public static void AddLanguageNode(XmlDocument doc, string key, string value, bool asInnerText = false)
		{
			var root = doc.SelectSingleNode("localizationDictionary");

			var node = doc.CreateElement("texts/data");
			
			var nameAtt = doc.CreateAttribute("name");
			nameAtt.Value = key;
			node.Attributes.Append(nameAtt);
			if (!asInnerText)
			{
				var valueAtt = doc.CreateAttribute("value");
				valueAtt.Value = value;
				node.Attributes.Append(valueAtt);
			}
			else
			{
				node.InnerText = value;
			}

			root.AppendChild(node);
		}


		public static void SetDataValue(XmlDocument doc, XmlNode dataNode, string value, bool asInnerText = false)
		{
			var valueAttr = GetDataValue(dataNode, null, out bool asInnerTextIgnore, out bool alreadyTranslated);
			if (valueAttr == null)
			{
				if (asInnerText)
				{
					dataNode.InnerText = value;
				} else
				{
					var valueAtt = doc.CreateAttribute("value");
					valueAtt.Value = value;
					dataNode.Attributes.Append(valueAtt);
				}
			}
			else
			{
				if (asInnerText)
				{
					dataNode.InnerText = value;
				}
				else
				{
					dataNode.Attributes["value"].Value = value;
				}
			}
		}

		public static string GetDataKeyName(XmlNode dataNode)
		{
			if (dataNode == null)
				return string.Empty;

			return dataNode.Attributes["name"].Value;
		}

		public static string GetDataValue(XmlNode dataNode, List<XmlNode> targetNodeList, out bool asInnerText, out bool alreadyTranslated)
		{
			asInnerText = false;
			alreadyTranslated = false;

			if (dataNode == null)
				return string.Empty;

			XmlElement asXele = dataNode as XmlElement;
			if ((asXele != null) && asXele.HasAttribute("value"))
			{
				return asXele.Attributes["value"].Value;
			}
			asInnerText = true;
			XmlNode targetNode = targetNodeList != null ? targetNodeList.FirstOrDefault(n => n.Attributes["name"].Value == asXele.Attributes["name"].Value): null;
			if (targetNode != null)
			{
				XmlElement targetXele = targetNode as XmlElement;
				if (!string.IsNullOrEmpty(targetNode.InnerText))
				{
					alreadyTranslated = true;
					return targetNode.InnerText;
				}
			}
			return dataNode.InnerText;
		}

		public static string GetInnerText(XmlNode dataNode)
		{
			if (dataNode == null)
				return string.Empty;

			return dataNode.InnerText;
		}

	}
}
