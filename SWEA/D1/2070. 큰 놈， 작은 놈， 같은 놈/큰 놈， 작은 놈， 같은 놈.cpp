#include <stdio.h>

int main()
{
int t;
scanf("%d",&t);

for(int i=1;i<=t;i++)
{
int a,b;
scanf("%d %d",&a,&b);



if(a>b) printf("#%d >\n",i);
else if(a<b) printf("#%d <\n",i);
else printf("#%d =\n",i);

}
return 0;
}