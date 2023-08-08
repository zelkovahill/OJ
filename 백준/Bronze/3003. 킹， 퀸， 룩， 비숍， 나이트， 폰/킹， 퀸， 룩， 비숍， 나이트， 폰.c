#include <stdio.h>

int main()
{
    int arr[6]={1,1,2,2,2,8};
    int arr_1[6]={0};

    for(int i =0; i<6;i++)
    {
        scanf("%d",&arr_1[i]);
        printf("%d ",arr[i]-arr_1[i]);
    }
    
    return 0;
}