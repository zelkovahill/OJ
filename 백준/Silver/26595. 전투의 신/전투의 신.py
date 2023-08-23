N=int(input())

ls=list(map(int,input().split()))

cntA,cntB,Sum,Max=0,0,0,0
ansA,ansB=0,0

for i in range(N):
    cntA=(N-i)//ls[1]
    cntB=(i//ls[3])
    Sum=ls[0]*cntA+ls[2]*cntB

    if Sum>=Max:
        Max=Sum
        ansA=cntA
        ansB=cntB

print(str(ansA)+" "+str(ansB))