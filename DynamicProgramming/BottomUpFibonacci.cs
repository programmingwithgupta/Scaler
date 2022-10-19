using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        int n = int.Parse(Console.ReadLine());
        int res = fib(n);
        Console.WriteLine(res);

    }


    static int fib(int n){

        int[] cache = new int[n+1];

        cache[0] = 0;
        cache[1] = 1;

        for(int i=2 ; i <=n ; i++){
            cache[i] = cache[i-1] + cache[i-2];
        }

        return cache[n];
    }
}