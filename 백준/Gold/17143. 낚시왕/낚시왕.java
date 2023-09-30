
import java.io.*;
import java.util.*;


public class Main
{
        static int R, C, M, king, result;
        static int[][] myMap, nextMap;
        static Shark[] sharks;

        static int[] dr = {-1, 0, 1, 0};
        static int[] dc = {0, 1, 0, -1};


        public static void main(String[] args) throws Exception 
        {

            BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
            StringTokenizer st = new StringTokenizer(br.readLine());

            R = Integer.parseInt(st.nextToken());
            C = Integer.parseInt(st.nextToken());
            M = Integer.parseInt(st.nextToken());


            king = -1;
            result = 0;

            myMap = new int[R][C];
            nextMap = new int[R][C];
            sharks = new Shark[M+1];

            for (int m = 1; m <= M; m++) 
            {
                st = new StringTokenizer(br.readLine());

                int r = Integer.parseInt(st.nextToken())-1;
                int c = Integer.parseInt(st.nextToken())-1;
                int s = Integer.parseInt(st.nextToken());
                int d = Integer.parseInt(st.nextToken());
                int z = Integer.parseInt(st.nextToken());

                switch (d) 
                {
                    case 1: d = 0;break;
                    case 2: d = 2;break;
                    case 3: d = 1;break;
                    case 4: d = 3;break;
                    default: break;
                }
                sharks[m] = new Shark(r, c, s, d, z);
                nextMap[r][c] = m;
            }

            while (king < C-1) 
            {
                king++;
                for (int r = 0; r < R; r++)
                {
                    for (int c = 0; c < C; c++)
                    {
                        myMap[r][c] = nextMap[r][c];
                    }
                }

                nextMap = new int[R][C];


                for (int y = 0; y < R; y++)
                {
                    int temp = myMap[y][king];

                    if (temp > 0)
                    {
                        result += sharks[temp].z;
                        sharks[temp].z = 0;
                        myMap[y][king] = 0;
                        break;
                    }
                }

               
                for (int m = 1; m <= M; m++)
                {
                    if (sharks[m].z == 0) continue;

                    Shark shrk = sharks[m];

                    if (shrk.s > 0)
                    {
                        shrk = moveShark(shrk);
                    }


                    if (nextMap[shrk.r][shrk.c] > 0)
                    {

                        if (sharks[nextMap[shrk.r][shrk.c]].z > shrk.z)
                        {
                            sharks[m].z = 0;
                            continue;
                        }


                        else
                        {
                            sharks[nextMap[shrk.r][shrk.c]].z = 0;
                        }
                        
                    }
                    sharks[m] = shrk;
                    nextMap[shrk.r][shrk.c] = m;
                }
            }

            System.out.println(result);

        }

        public static Shark moveShark(Shark shrk)
        {
            int speed = shrk.s;
            int y = shrk.r;
            int x = shrk.c;
            while (true)
            {
                int yr = y + dr[shrk.d] * speed;
                int xr = x + dc[shrk.d] * speed;


                if (yr < 0)
                {
                    speed -= y;
                    y = 0;
                }
                
                else if (yr >= R)
                {
                    speed -= (R-1) - y;
                    y = R-1;
                }
                
                else if (xr < 0)
                {
                    speed -= x;
                    x = 0;
                }
                
                else if (xr >= C)
                {
                    speed -= (C-1) - x;
                    x = C-1;
                }

                else
                {
                    shrk.r = yr;
                    shrk.c = xr;
                    return shrk;
                }

                shrk.d = (shrk.d + 2) % 4;
            }
        }

    }

    class Shark
    {
        int r;
        int c;
        int s;
        int d;
        int z;

        Shark(int r, int c, int s, int d, int z)
        {
            this.r = r;
            this.c = c;
            this.s = s;
            this.d = d;
            this.z = z;
        }
    }
