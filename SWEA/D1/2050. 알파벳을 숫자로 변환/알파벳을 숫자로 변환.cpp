#include <stdio.h>

int main()
{
    char arr[26] ={ 0, };

   
        scanf("%s",arr);
    
    for(int i=0;i<26;i++)
    {
        printf("%d ",arr[i]-64);
    }

    return 0;
}