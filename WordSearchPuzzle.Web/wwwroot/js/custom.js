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
            cell.classList.add('word-' + word);
        });
    });
}

function clearHighlights() {
    var cells = document.querySelectorAll('.matrix-cell');

    if ((cells !== undefined || cells !== null) && cells.length > 0) {
        cells.forEach(cell => {
            if (cell.classList.contains('highlight')) {
                cell.classList.remove('highlight');
            }
        });
    }
}

function highlightWord(word)
{
    var cells = document.querySelectorAll('.word-' + word);

    cells.forEach(cell => {
        if (!cell.classList.contains('highlight2')) {
            cell.classList.add('highlight2');
        }
    });
}

function removehighlightedWord(word)
{
    var cells = document.querySelectorAll('.word-' + word);
    if ((cells !== undefined || cells !== null) && cells.length > 0) {
        cells.forEach(cell => {
            if (cell.classList.contains('highlight2')) {
                cell.classList.remove('highlight2');
            }
        });
    }
}
