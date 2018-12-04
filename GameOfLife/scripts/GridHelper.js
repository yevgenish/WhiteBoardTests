var GridHelper = function () {

    function createEmptyGrid(xSize, ySize) {
        var arr = new Array(xSize);
        for (var i = 0; i < xSize; i++) {
            arr[i] = new Array(ySize);
        }
        return arr;
    }

    function createFilledGrid(xSize, ySize) {
        var grid = createEmptyGrid(xSize, ySize);   
        for (var i = 0; i < ySize; i++) {
            for (var j = 0; j < xSize; j++) {
                grid[i][j] = 1;
            }
        }
        return grid;
    }

    function copyGrid(grid) {
        var newGrid = JSON.parse(JSON.stringify(grid));
        return newGrid;
    }

    return {
        createEmptyGrid: createEmptyGrid,
        createFilledGrid: createFilledGrid,
        copyGrid: copyGrid
    };
};