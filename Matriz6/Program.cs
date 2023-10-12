using System.Globalization;

int N = int.Parse(Console.ReadLine());

double[,] mat = new double[N, N];

// Leitura de dados
for (int i = 0; i < N; i++) {
    string[] s = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++) {
        mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
    }
}

int linha = int.Parse(Console.ReadLine());
int coluna = int.Parse(Console.ReadLine());

// Soma dos positivos
double soma = 0.0;
for (int i = 0; i < N; i++) {
    for (int j = 0; j < N; j++) {
        if (mat[i, j] > 0.0) {
            soma += mat[i, j];
        }
    }
}

Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

// Linha escolhida
Console.Write("LINHA ESCOLHIDA: ");
for (int j = 0; j < N; j++) {
    Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

Console.WriteLine();

// Coluna escolhida
Console.Write("COLUNA ESCOLHIDA: ");
for (int i = 0; i < N; i++) {
    Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

Console.WriteLine();

// Diagonal Principal
Console.Write("DIAGONAL PRINCIPAL: ");
for (int i = 0; i < N; i++) {
    Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

Console.WriteLine();

// Matriz Alterada
for (int i = 0; i < N; i++) {
    for (int j = 0; j < N; j++) {
        if (mat[i, j] < 0.0) {
            mat[i, j] = Math.Pow(mat[i, j], 2.0);
        }
    }
}

Console.WriteLine("MATRIZ ALTERADA:");
for (int i = 0; i < N; i++) {
    for (int j = 0; j < N; j++) {
        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();
}