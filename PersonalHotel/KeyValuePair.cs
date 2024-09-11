namespace PersonalHotel
{
	public struct KeyValuePair
	{
		public string Name;
		public object? Value;

		public KeyValuePair(string name, object? value)
		{
			Name = name;
			Value = value;
		}
	}
}
