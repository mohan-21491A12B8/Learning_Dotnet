using System;
class Arr1{
    static void Main(string[] args){
        int[][] a1 = new int[3][];
        a1[0]=new int[]{2,53,6,4,6};
        a1[1]=new int[]{1,2,3,4,5,6};
        a1[2]=new int[]{6,2};
        for (int i=0;i<a1.Length;i++){
            for(int j=0;j<a1[i].Length;j++){
                Console.Write(a1[i][j]+" ");
            }
            Console.WriteLine();
        }
     }
}