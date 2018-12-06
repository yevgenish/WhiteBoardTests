/// <reference path="gridhelper.js" />

var GOL = function (gridHelper) {

    function getGridByGen(grid, gen) {
        var resGrid;
        for (var i = 0; i < gen; i++) {
            if (i == 0) {
                resGrid = getGridGen1(grid);
            } else {
                resGrid = getGridGen1(resGrid);
            }
        }

        return resGrid;
    }

    function getGridGen1(grid) {
        var gridLength = grid.length;

        var dupGrid = gridHelper.copyGrid(grid);
        var resGrid = gridHelper.createEmptyGrid(gridLength, gridLength);

        for (var i = 0; i < gridLength; i++) {
            for (var j = 0; j < gridLength; j++) {
                var liveDeadNeighbours = getNeighboursStatus(dupGrid, { x: i, y: j });
                var liveAmount = liveDeadNeighbours.liveAmount;
                var deadAmount = liveDeadNeighbours.deadAmount;

                var currentCellStatus = dupGrid[i][j];
                var newCellStatus = currentCellStatus;
                if (currentCellStatus == 1) {
                    if (liveAmount < 2) {
                        newCellStatus = 0;
                    }
                    else if (liveAmount == 2 || liveAmount == 3) {
                        newCellStatus = 1;
                    }
                    else if (liveAmount > 3) {
                        newCellStatus = 0;
                    }
                } else if (currentCellStatus == 0) {
                    if (liveAmount == 3) {
                        newCellStatus = 1;
                    }
                }
                resGrid[i][j] = newCellStatus;
            }
        }

        return resGrid;
    }

    function getNeighboursStatus(grid, pos) {

        var gridLength = grid.length;
        var liveAmount = 0;
        var deadAmount = 0;

        // 0 | 1 | 2
        // 3 | e | 4
        // 5 | 6 | 7

        for (var i = 0; i < 7; i++) {
            var x, y;
            if (i == 0) {
                x = pos.x - 1;
                y = pos.y - 1;
            }
            else if (i == 1) {
                x = pos.x;
                y = pos.y - 1;
            }
            else if (i == 2) {
                x = pos.x + 1;
                y = pos.y + 1;
            }
            else if (i == 3) {
                x = pos.x - 1;
                y = pos.y;
            }
            else if (i == 4) {
                x = pos.x + 1;
                y = pos.y;
            }
            else if (i == 5) {
                x = pos.x - 1;
                y = pos.y + 1;
            }
            else if (i == 6) {
                x = pos.x;
                y = pos.y + 1;
            }
            else if (i == 7) {
                x = pos.x + 1;
                y = pos.y + 1;
            }

            //if (!((x < 0 || y < 0) || (x > gridLength - 1 || y > gridLength - 1))) {
            if ((x >= 0 && y >= 0) && (x <= gridLength - 1 && y <= gridLength - 1)) {
                var currVal = grid[x][y];
                if (currVal == 0) {
                    deadAmount++;
                } else if (currVal == 1) {
                    liveAmount++;
                }
            }

        }

        return { liveAmount: liveAmount, deadAmount: deadAmount };
    }

    return {
        getGridByGen: getGridByGen
    };
}