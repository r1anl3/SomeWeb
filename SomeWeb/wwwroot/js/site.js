const menuBar = document.querySelector('.content nav .bx.bx-menu');
const sideBar = document.querySelector('.sidebar');
const sideMenuItems = document.querySelectorAll('.sidebar .side-menu li a:not(.logout)');

menuBar.addEventListener('click', () => {
    sideBar.classList.toggle('close');
});

console.log(Date())