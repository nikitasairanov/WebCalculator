// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Выбор операции из выпадающего списка


//HTTP-Запросы
document.getElementById("calculate-btn").onclick = function()
{
    const xhr = new XMLHttpRequest();
    xhr.open('POST', `https://localhost:7197/home/GetData?a=${Number(document.getElementById("number1").value)}&b=${Number(document.getElementById("number2").value)}`);
    xhr.onload = () => {
        const xhr2 = new XMLHttpRequest();
        xhr2.open('GET', `https://localhost:7197/home/Operation?id=${Number(document.getElementById("operations").selectedIndex)}`);
        xhr2.onload = () => {
            console.log(xhr2.response)
            document.getElementById("result").value = xhr2.response;
        }
        xhr2.send();
    }
    xhr.send();
}