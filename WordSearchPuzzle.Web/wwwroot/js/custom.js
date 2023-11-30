function highlightWordsWithCoordinates(wordsWithCoordinates, matrixSize) {
    clearHighlights();

    var cells = document.querySelectorAll('.matrix-cell');
    wordsWithCoordinates.forEach(wordInfo => {
        const { word, coordinates } = wordInfo;

        coordinates.forEach(coord => {
            const { x, y } = coord;

            const index = x * matrixSize + y;

            const cell = cells[index];

            cell.classList.add('highlight');
        });
    });
}

function clearHighlights() {
    var cells = document.querySelectorAll('.matrix-cell');

    if ((cells !== undefined || cells !== null) && cells.length > 0) {
        cells.forEach(function (cell) {
            if (cell.classList.contains('highlight')) {
                cell.classList.remove('highlight');
            }
        });
    }
}
