#include <stdio.h>

int main()
{
    int n;
    scanf("%d",&n);

for(int i=0;i<n;i++)
{
    char a[100];
    scanf("%s",a);
    if(a[0]=='A')
    {
        if(a[1]=='l') printf("204\n");
        else printf("302\n");
    }

    else if(a[0]=='D') printf("207\n");
    else if(a[0]=='C') printf("B101\n");
    else if(a[0]=='N') printf("303\n");
    else if(a[0]=='S') printf("501\n");
    else if(a[0]=='T') printf("105\n");


}
return 0;
}