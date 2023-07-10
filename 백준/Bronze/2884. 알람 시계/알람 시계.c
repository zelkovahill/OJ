#include <stdio.h>

int main()
{
    int a, b;

    scanf("%d %d", &a, &b);

    if (b >= 45) 
    {
        b -= 45;
    } 
    else
     {
       b += 15;
     
        if (a == 0)
         {
            a = 23;
        } 
        else 
        {
            a--;
        }
    }

    printf("%d %d\n", a, b);

    return 0;
}
