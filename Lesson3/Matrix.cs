namespace Lesson3;

public class Matrix
{
    private double[,] _matrix;
    public int Rows => _matrix.GetLength(0);
    public int Columns => _matrix.GetLength(1);

    public Matrix(double[,] matrix)
    {
        _matrix = matrix;
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            throw new ArgumentException("Matice musi mit stejne rozmery");

        double[,] result = new double[m1.Rows, m1.Columns];

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1._matrix[i, j] + m2._matrix[i, j];
            }
        }

        return new Matrix(result);
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            throw new ArgumentException("Matice musi mit stejne rozmery");

        double[,] result = new double[m1.Rows, m1.Columns];

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1._matrix[i, j] - m2._matrix[i, j];
            }
        }

        return new Matrix(result);
    }

    public static Matrix operator -(Matrix m)
    {
        double[,] result = new double[m.Rows, m.Columns];
        
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Columns; j++)
            {
                result[i, j] = -m._matrix[i, j];
            }
        }

        return new Matrix(result);
    }

public static Matrix operator *(double scalar, Matrix m)
    {
        double[,] result = new double[m.Rows, m.Columns];
        
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Columns; j++)
            {
                result[i, j] = scalar * m._matrix[i, j];
            }
        }

        return new Matrix(result);
    }
    
    public static Matrix operator *(Matrix m, double scalar) => scalar * m;
    
    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.Columns != m2.Rows)
            throw new ArgumentException("Matice musi mit stejny pocet sloupcu a radku");
        
        double[,] result = new double[m1.Rows, m2.Columns];
        
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m2.Columns; j++)
            {
                for (int k = 0; k < m1.Columns; k++)
                {
                    result[i, j] += m1._matrix[i, k] * m2._matrix[k, j];
                }
            }
        }

        return new Matrix(result);
    }

    public static bool operator ==(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            return false;
        
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m2.Columns; j++)
            {
                if (m1._matrix[i, j] != m2._matrix[i, j])
                    return false;
            }
        }

        return true;
    }
    
    public static bool operator !=(Matrix m1, Matrix m2) => !(m1 == m2);

    public double Determinant()
    {
        if (Rows != Columns) 
            throw new ArgumentException("Matice musi byt ctvercova");

        return Rows switch
        {
            1 => _matrix[0, 0],
            2 => _matrix[0, 0] * _matrix[1, 1] - _matrix[0, 1] * _matrix[1, 0],
            3 => _matrix[0, 0] * _matrix[1, 1] * _matrix[2, 2] + _matrix[0, 1] * _matrix[1, 2] * _matrix[2, 0] +
                 _matrix[0, 2] * _matrix[1, 0] * _matrix[2, 1] - _matrix[0, 2] * _matrix[1, 1] * _matrix[2, 0] -
                 _matrix[0, 1] * _matrix[1, 0] * _matrix[2, 2] - _matrix[0, 0] * _matrix[1, 2] * _matrix[2, 1],
            _ => throw new ArgumentException("Matice je vetsi nez 3x3")
        };
    }

    public override string ToString()
    {
        string result = "| ";
        
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                result += _matrix[i, j] + " ";
            }

            result += "|";
            if (i < Rows - 1) result += "\n| ";
        }

        return result;
    }
}