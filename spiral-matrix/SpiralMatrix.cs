public class SpiralMatrix
{
    public static (int, int) Move(string dir, (int, int) currentPos) =>
          dir == "left" ? (currentPos.Item1, currentPos.Item2 - 1)
        : dir == "right" ? (currentPos.Item1, currentPos.Item2 + 1)
        : dir == "up" ? (currentPos.Item1 - 1, currentPos.Item2)
        : (currentPos.Item1 + 1, currentPos.Item2);
    public static bool Edge((int, int) currentPos, string dir, int size, int spiralSize) =>
          dir == "right" ? currentPos.Item2 == spiralSize - 1
        : dir == "down" ? currentPos.Item1 == spiralSize - 1
        : dir == "left" ? currentPos.Item2 == size - spiralSize
        : currentPos.Item1 == size - spiralSize;
    public static int[,] GetMatrix(int size)
    {
        if (size < 1) return new int[size, size];
        int[,] spiral = new int[size, size];
        (int, int) currentPos = (0, 0);
        int spiralSize = size, counter = 1;
        string dir = "right";
        while (counter < size * size)
        {
            while (!Edge(currentPos, dir, size, spiralSize))
            {
                spiral[currentPos.Item1, currentPos.Item2] = counter++;
                currentPos = SpiralMatrix.Move(dir, currentPos);
            }
            dir = dir == "right" ? "down" : dir == "down" ? "left" : dir == "left" ? "up" : "right";
            if (dir == "up") { spiralSize--; }
        }
        spiral[currentPos.Item1, currentPos.Item2] = counter;
        return spiral;
    }
}
