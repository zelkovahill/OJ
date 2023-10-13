/******************************************************************************

Welcome to GDB Online.
  GDB online is an online compiler and debugger tool for C, C++, Python, PHP, Ruby, 
  C#, OCaml, VB, Perl, Swift, Prolog, Javascript, Pascal, COBOL, HTML, CSS, JS
  Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <stdio.h>

int main()
{
    int t;
    scanf("%d",&t);
    
    for(int i = 0; i<t;i++)
    {
        int ans=0;
        int n, s , d;
        scanf("%d %d %d",&n,&s,&d);
        int and = s*d;
        
        for(int j=0;j<n;j++)
        {
        int a, b;
        scanf("%d %d",&a,&b);
        if(and>=a) ans+=b;
        
        }
        printf("Data Set %d:\n%d\n",i+1,ans);
        if(i<t) printf("\n");
        
        
        
    }

    return 0;
}
