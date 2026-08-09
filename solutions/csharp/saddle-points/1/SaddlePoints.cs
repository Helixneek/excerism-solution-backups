public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var allCoords = from rowIdx in Enumerable.Range(0, matrix.GetLength(0))
                        from colIdx in Enumerable.Range(0, matrix.GetLength(1))
                        select (Row: rowIdx + 1, Col: colIdx + 1, Value: matrix[rowIdx, colIdx]);

        var rowMaxima = (from coord in allCoords
                        group coord by coord.Row into rowGroup
                        let maxRowValue = rowGroup.Max(p => p.Value)
                        from matchingPoint in rowGroup
                        where matchingPoint.Value == maxRowValue
                        select matchingPoint).ToList(); 

        var colMaxima = (from coord in allCoords
                        group coord by coord.Col into colGroup
                        let minColValue = colGroup.Min(p => p.Value)
                        from matchingPoint in colGroup
                        where matchingPoint.Value == minColValue
                        select matchingPoint).ToList(); 

        var validTrees = rowMaxima.Intersect(colMaxima);
        var finalTrees = validTrees.Select(x => (x.Row, x.Col));

        return finalTrees;
    }
}
