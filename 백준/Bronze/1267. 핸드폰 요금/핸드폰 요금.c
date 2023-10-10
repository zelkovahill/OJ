#include <stdio.h>

int main()
{
 int n;
 scanf("%d",&n);
 
 int use[n];
 int young=0,min=0;
 
 for(int i = 0; i<n;i++)
 {
     scanf("%d",&use[i]);
 }
 
 for(int i = 0; i<n;i++)
 {
     young+=10*((use[i]/30)+1);
     min+=15*((use[i]/60)+1);
 }
 
 
 
 if(min>young) printf("Y %d\n",young);
 else if(min<young) printf("M %d\n",min);
 else printf("Y M %d\n",min);
 
 return 0;  
}
