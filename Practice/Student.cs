using System;
namespace Practice
{
	public class Student
	{
		public Student()
		{
			_uniqueID++;
			_no = _uniqueID;

		}
		private int _no;
		public string FullName;
		private string _groupNo;
		private static int _uniqueID = 0;
		public string GroupNo
        {
            get
            {
				return _groupNo;
            }
            set
            {
                bool check = true;
                if (!string.IsNullOrWhiteSpace(value) && Char.IsLetter(value[0]) == true && value.Length==4)
                {
                    for (int i = 1; i < 4; i++)
                    {
                        if (!Char.IsDigit(value[i]))
                        {
                            check = false;
                        }
                    }
                    if (check)
                    {
                        _groupNo = value;
                    }
                }
            }
        }
	}
}

