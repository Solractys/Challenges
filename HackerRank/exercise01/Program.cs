int n = 9;
        for (int i = 1; i <= n; i++) { 
            for (int b = 0; b < i; b++) {
                Console.Write("#");
            }
            for (int a = 0; a < n - i; a++) {
                Console.Write(" ");
            }
            if (i == n) {}
        Console.WriteLine();
        }