#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int number, int n, int m) {
    if(number%n==0&&number%m==0) return 1;
    else  return 0;
    
   
}

int main()
{
    int number , n, m;
    
    scanf("%d %d %d",&number,&n,&m);
    bool a = solution(number,n,m);

    printf("%d\n",a);
    return 0;
}