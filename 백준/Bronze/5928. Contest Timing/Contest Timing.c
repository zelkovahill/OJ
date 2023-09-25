#include <stdio.h>

int main()
{
  int d,h,m;
  scanf("%d %d %d",&d,&h,&m);

  int t1 = 11*60*24+11*60+11;
  int t2 = d*60*24+h*60+m;
  int result = t2-t1;

  printf("%d\n",result<0?-1:result);
}