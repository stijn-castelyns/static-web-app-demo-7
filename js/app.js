async function loadBooks() {
  const response = await fetch("/api/getbooks");
  const books = await response.json();

  const list = document.getElementById("book-list");
  for (const book of books) {
    const item = document.createElement("li");
    item.innerHTML = `<strong>${book.title}</strong><br><span class="author">${book.author}, ${book.year}</span>`;
    list.appendChild(item);
  }
}

document.getElementById("host").textContent = window.location.host;
loadBooks();
