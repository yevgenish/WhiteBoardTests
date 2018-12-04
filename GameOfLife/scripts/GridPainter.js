var GridPainter = function () {
    function getGridHtml(grid) {
        var gridHeight = grid[0].length;
        var gridLength = grid.length;

        var res = '<table>';
        for (var i = 0; i < gridHeight; i++) {
            res += '<tr>';
            for (var j = 0; j < gridLength; j++) {
                res += '<td>' + grid[i][j] + '</td>';
            }
            res += '</tr>';
        }

        res += '</table>';

        return res;
    }

    return {
        getGridHtml: getGridHtml
    };
};