#include <stdio.h>




int main()
{

int si,bun,next; // 시 , 분 , 걸리는 시간


scanf("%d %d\n %d",&si,&bun,&next);

if(bun+next>=60)
{
    if(si+(bun+next/60)>=24)
    {
        printf("%d %d\n",(si+(bun+next)/60)%24,(bun+next)%60);
    }
    else
    {
        printf("%d %d\n",si+(bun+next)/60,(bun+next)%60);
    }
}
else
{
    printf("%d %d\n",si,bun+next);
}


return 0;
}
