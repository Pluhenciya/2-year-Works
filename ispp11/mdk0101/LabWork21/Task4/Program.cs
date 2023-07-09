Console.WriteLine(GetDaysCount(2, 2024));

int GetDaysCount(int month, int year)
{
	if (month < 1 || month > 12)
		return -1;
	if (month == 4 || month == 6 || month == 9 || month == 11)
		return 30;
	if (month != 2)
		return 31;
	return (year % 100 != 0 && year % 4 == 0 || year % 400 == 0) ? 29 : 28;
}

