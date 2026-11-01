# Трассировка рекурсивной функции (Задание t05/srs)

Исходная функция:
```csharp
static int F(int n) 
{ 
    if (n <= 1) return 1; 
    return n * F(n - 1); 
}
