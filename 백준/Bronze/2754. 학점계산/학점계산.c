#include<stdio.h>

int main(void){
	double score = 0.0;
	char sign;
	char grade;

	scanf("%c", &grade);
	if (grade == 'F')
	{
		printf("0.0");
	}
	scanf("%c", &sign);
	
	switch (grade)
	{
	case 'A': 
		switch (sign)
		{
			case'+': score = 4.3;
				break;
			case'0': score = 4.0;
				break;
			case'-': score = 3.7;
				break;
		} printf("%.1lf", score);
		break;
	case 'B': 
		switch (sign)
		{
			case'+': score = 3.3;
				break;
			case'0': score = 3.0;
				break;
			case'-': score = 2.7;
				break;
		} printf("%.1lf", score);
		break;
	case 'C':
		switch (sign)
		{
			case'+': score = 2.3;
				break;
			case'0': score = 2.0;
				break;
			case'-': score = 1.7;
				break;
		} printf("%.1lf", score);
		break;
	case 'D': 
		switch (sign)
		{
			case'+': score = 1.3;
				break;
			case'0': score = 1.0;
				break;
			case'-': score = 0.7;
				break;
		} printf("%.1lf", score);
		break;
	}

	
}
