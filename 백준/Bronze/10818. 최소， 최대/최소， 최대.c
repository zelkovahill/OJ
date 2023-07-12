#include <stdio.h>

int main()
{
    int N;

    scanf("%d",&N);
    int a[N];

    for(int i=0;i<N;i++)
    {
        scanf("%d",&a[i]);
    }

int m=a[0],M=a[0];

for(int j=0;j<N;j++)
{
    if(a[j]<m)
    {
        m=a[j];
    }

    else if(a[j]>M)
    {
        M=a[j];
    }
}

printf("%d %d\n",m,M);

return 0;
}