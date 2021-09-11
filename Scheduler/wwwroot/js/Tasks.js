function searchByName(event) {
    let title = document.querySelector('#SearchQuery').value;

    if (!title) {
        alert('Please Enter Title');
        return;
    }

    event.target.disabled = true;
    $.ajax({
        method: 'POST',
        url: url + '/Tasks/Search?title=' + title,
        success: function (response) {
            document.querySelector('#searchResults').innerHTML = response;
        },
        complete: function () {
            event.target.disabled = false;
        }
    });
}