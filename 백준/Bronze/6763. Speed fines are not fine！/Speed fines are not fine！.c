#include <stdio.h>

int main()
{
    int a,b;
    scanf("%d\n%d",&a,&b);
    int sum = b-a;

    if(1<=sum&&sum<=20) printf("You are speeding and your fine is $100.");
    else if(21<=sum&&sum<=30) printf("You are speeding and your fine is $270.");
    else if(31<=sum) printf("You are speeding and your fine is $500.");
    else printf("Congratulations, you are within the speed limit!");


    return 0;
}