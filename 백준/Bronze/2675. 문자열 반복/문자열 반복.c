#include <stdio.h>
#include <string.h>

int main()
{
    char a[1000];

    int b;  // 횟수
    int c;  // 반복 횟수


    scanf("%d",&b); // 몇개 만들긔

    for(int i=0;i<b;i++)
    {
        scanf("%d %s",&c,a);

        for(int j=0;j<strlen(a);j++)
        {   
           for(int k=0;k<c;k++)
           {
            printf("%c",a[j]);
           }

            
        }


printf("\n");
    }


return 0;
}