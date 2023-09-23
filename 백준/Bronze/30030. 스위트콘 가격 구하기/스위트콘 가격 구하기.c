#include <stdio.h>

int main()
{
int B;
scanf("%d",&B);
int A = B*0.9;
if(A%100!=0)
{
    while(A%100!=0)
    {
        A+=1;
    }
}
printf("%d\n",A);

}
