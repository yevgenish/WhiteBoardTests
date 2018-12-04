/// <reference path="gridhelper.js" />
/// <reference path="gol.js" />
/// <reference path="gridpainter.js" />

(function () {
    var $appDiv = $('.app');

    var gridHelper = new GridHelper();
    var gol = new GOL(gridHelper);
    var gridPainter = new GridPainter();

    function appendGridToView(title, grid) {
        var gridHtml = gridPainter.getGridHtml(grid);

        $appDiv.append('<h3>' + title +'</h3>' + gridHtml + '<br /><hr />')
    }

    var grid = gridHelper.createFilledGrid(3, 3);
    appendGridToView('Original', grid);


    var gridGen1 = gol.getGridByGen(grid, 1);
    appendGridToView('Gen 1', gridGen1);


    var gridGen2 = gol.getGridByGen(gridGen1, 1);
    appendGridToView('Gen 2', gridGen2);


    var gridGen2Direct = gol.getGridByGen(grid, 2);
    appendGridToView('Gen 2 Direct', gridGen2Direct);


    $appDiv.append('<hr /><h2>New Game</h2>');
    appendGridToView('Gen 0', grid);
    for (var i = 1; i <= 5; i++) {
        var gridGenNext = gol.getGridByGen(grid, i);
        appendGridToView('Gen ' + i, gridGenNext);
    }

    $appDiv.append('<hr /><h2>New Game 2 - 10x10</h2>');
    var grid2 = gridHelper.createFilledGrid(10, 10);

    appendGridToView('Gen 0', grid2);
    for (var i = 1; i <= 5; i++) {
        var grid2GenNext = gol.getGridByGen(grid2, i);
        appendGridToView('Gen ' + i, grid2GenNext);
    }

})();