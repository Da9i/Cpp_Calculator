#include<iostream>
using namespace std;
//for int calculations.
int add(int& a, int& b)
{
	return a + b;
}
int sub(int& a, int& b)
{
	return a - b;
}
int mul(int& a, int& b)
{
	return a * b;
}
int divide(int& a, int& b)
{
	return a / b;
}
//for float calculation.
float add(float& a, float& b)
{
	return a + b;
}
float sub(float& a, float& b)
{
	return a - b;
}
float mul(float& a, float& b)
{
	return a * b;
}
float divide(float& a, float& b)
{
	return a / b;
}
int main()
{

	int opt, option;
	int num1 = 0, num2 = 0;
	float fnum1 = 0, fnum2 = 0;
	cout << "ENTER 1 FOR ADDITION :" << endl;
	cout << "ENTER 2 FOR SUBTRACTION :" << endl;
	cout << "ENTER 3 FOR MULTIPLICATION :" << endl;
	cout << "ENTER 4 FOR DIVISION :" << endl;
	cout << "ENTER 5 TO EXIT :" << endl;
	cin >> opt;
	while (opt != 5)
	{
		if (opt == 1)
		{
			cout << "PRESS 1 FOR INTEGERS AND 2 FOR FLOAT :" << endl;
			cin >> option;
			if (option == 1)
			{
				cout << "ENTER TWO NUMBERS :" << endl;
				cin >> num1 >> num2;
				cout << "SUM BY INTEGER :"<<add(num1, num2) << endl;
			}
			else if (option == 2)
			{
				cout << "ENTER TWO NUMBERS :" << endl;
				cin >> fnum1 >> fnum2;
				cout <<"SUM BY FLOAT :"<< add(fnum1, fnum2) << endl;
			}
		}
		else if (opt == 2)
		{
			cout << "PRESS 1 FOR INTEGERS AND 2 FOR FLOAT :" << endl;
			cin >> option;
			if (option == 1)
			{
				cout << "ENTER TWO NUMBERS :" << endl;
				cin >> num1 >> num2;
				cout << "DIFFERENCE BY INTEGER :" << sub(num1, num2) << endl;
			}
			else if (option == 2)
			{
				cout << "ENTER TWO NUMBERS :" << endl;
				cin >> fnum1 >> fnum2;
				cout << "DIFFERENCE BY FLOAT :" << sub(fnum1, fnum2) << endl;
			}
		}
		else if (opt == 3)
		{
			cout << "PRESS 1 FOR INTEGERS AND 2 FOR FLOAT :" << endl;
			cin >> option;
			if (option == 1)
			{
				cout << "ENTER TWO NUMBERS :" << endl;
				cin >> num1 >> num2;
				cout << "PRODUCT BY INTEGER :" << mul(num1, num2) << endl;
			}
			else if (option == 2)
			{
				cout << "ENTER TWO NUMBERS :" << endl;
				cin >> fnum1 >> fnum2;
				cout << "PRODUCT BY FLOAT :" << mul(fnum1, fnum2) << endl;
			}
		}
		else if (opt == 4)
		{
			cout << "PRESS 1 FOR INTEGERS AND 2 FOR FLOAT :" << endl;
			cin >> option;
			if (option == 1)
			{
				cout << "ENTER TWO NUMBERS :" << endl;
				cin >> num1 >> num2;
				cout << "QUOTIENT BY INTEGER :" << divide(num1, num2) << endl;
			}
			else if (option == 2)
			{
				cout << "ENTER TWO NUMBERS :" << endl;
				cin >> fnum1 >> fnum2;
				cout << "QUOTIENT BY FLOAT :" << divide(fnum1, fnum2) << endl;
			}
		}
		system("pause>0");
		system("cls");
		cout << "ENTER 1 FOR ADDITION :" << endl;
		cout << "ENTER 2 FOR SUBTRACTION :" << endl;
		cout << "ENTER 3 FOR MULTIPLICATION :" << endl;
		cout << "ENTER 4 FOR DIVISION :" << endl;
		cout << "ENTER 5 TO EXIT :" << endl;
		cin >> opt;
	}
}
