using System.Reflection;

public static partial class ExtensionMethods
{
	public static void TrimStringProperties(object obj)
	{
		PropertyInfo[] properties = obj.GetType().GetProperties();

		foreach(PropertyInfo property in properties)
		{
			if(property.PropertyType == typeof(string))
			{
				string value = (string)property.GetValue(obj);

				if(value != null)
				{
					value = value.Trim();
					property.SetValue(obj, value);
				}
			}
		}
	}

}
