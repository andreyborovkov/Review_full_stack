document.addEventListener('DOMContentLoaded', () => {
    refreshTags();
    document
        .querySelector('#submit-new-tag')
        .addEventListener('click', submitNewTag);
});

function submitNewTag() {
    const textInput = document.querySelector('#new-tag');
    const text = textInput.value;
    fetch(`/api/tags?reviewId=${reviewId}`, {
        method: 'POST',
        body: JSON.stringify({ text }),
        headers: { 'Content-Type': 'application/json' }
    })
        .then(res => res.json())
        .then((data) => {
            textInput.value = '';
            addTagToDom(data, true);
        })
        .catch(console.error);
}

function refreshTags() {
    fetch(`/api/tags/${reviewId}`)
        .then((res) => res.json())
        .then((data) => data.forEach(addTagToDom))
}

function addTagToDom(tag, isAnimated) {
    const listItem = document.createElement('li');
    listItem.innerHTML = `<a href="/tags/details/${tag.id}">${tag.text}</a>`;
    document.querySelector('#tags-list').appendChild(listItem);
    if (isAnimated === true) {
        listItem.classList.add('transparent')
        setTimeout(() => { listItem.classList.remove('transparent') }, 0);
    }
}
