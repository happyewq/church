var title = document.getElementById("title");
var p1 = document.getElementById("p1");
var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var list = document.getElementById("list");

btn1.addEventListener("mouseover", function () {
    list.innerHTML = list.innerHTML + `
    <div style="width:100px; height:100px;
    position: absolute;
    top: 7%;
    left: -20%;">
    <img src="Eb.png" style="width:100px; height:100px";>   
    </div>`
})

btn1.addEventListener("mouseleave", function () {
    list.innerHTML = ``
})

btn2.addEventListener("mouseover", function () {
    list.innerHTML = list.innerHTML + `
                <div style="width:100px; height:100px;
                position: absolute;
                top: 40%;
                left: -20%;">
                <img src="Eb.png" style="width:100px; height:100px";>   
                </div>`
})

btn2.addEventListener("mouseleave", function () {
    list.innerHTML = ``
})

btn3.addEventListener("mouseover", function () {
    list.innerHTML = list.innerHTML + `
        <div style="width:100px; height:100px;
        position: absolute;
        top: 73%;
        left: -20%;">
        <img src="Eb.png" style="width:100px; height:100px";>   
        </div>`
})

btn3.addEventListener("mouseleave", function () {
    list.innerHTML = ``
})
