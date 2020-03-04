// maak een variabele voor de canvas
const canvas = document.getElementById('canvas');

// leg een 2d-context over de canvas
const context = canvas.getContext('2d');

//maak de canvas schermvullend
const width = window.innerWidth;
const height = window.innerHeight;
canvas.width = width;
canvas.height = height;

let playerscore = 0;
let enemyscore = 0;

let updatespeed = 8;
//
// circle (ball) begin
//
let ball = {};
ball.x = width / 2;
ball.y = height / 2;
ball.radius = 10;
ball.color = "white";
ball.speed = 2;
ball.speedX = -0.3;
ball.speedY = -0.1;

 ball.drawBall = () => {
  context.beginPath();
  context.fillStyle = ball.color;
  context.arc(ball.x, ball.y, ball.radius, 0, 2 * Math.PI);
  context.closePath();
  context.stroke();
  context.fill();
}

 ball.updateBall =()=> {
  for (let i = 0; i < ball.speed * 10; i++) {
    ball.x = ball.x + ball.speedX;
    ball.y = ball.y + ball.speedY;
    if (ball.y > height - ball.radius || ball.y < ball.radius) {
      ball.speedY = -ball.speedY;
    }

    //collsion score walls
    if(ball.x + ball.radius > width - (tabbleR.w - 1))
    {
      ball.speedX = - ball.speedX;
      ball.speedY = + ball.speedY;
      playerscore++;
      standaard();

      score();
    }
    if(ball.x - ball.radius < 0 + (tabbleL.w - 1) )
    {
      ball.speedX = - ball.speedX;
      ball.speedY = + ball.speedY;
      enemyscore++;
      standaard();

      score();
    }

    // controlle collision with tabbles

    //collision voorkant
    if (ball.x > tabbleR.x - ball.radius &&
      ball.y + ball.radius > tabbleR.y && ball.y - ball.radius < tabbleR.y + tabbleR.h) {
      ball.speedX = -ball.speedX;
      ball.speedY = +ball.speedY;
      ball.speed += 0.1;
    }

    if (ball.x > tabbleL.x + ball.radius && ball.x - ball.radius < tabbleL.x + tabbleL.w &&
      ball.y > tabbleL.y - ball.radius && ball.y + ball.radius < tabbleL.y + tabbleL.h) {
      ball.speedX = -ball.speedX;
      ball.speedY = +ball.speedY;
      ball.speed += 0.1;
    }
  }
}
function standaard() {
  ball.x = width / 2;
  ball.y = height / 2;
  ball.speed = 2;
}
//
// tabbleR (enemy)
//
let tabbleR = {};
tabbleR.h = 250; // the height of the rectangle in pixels
tabbleR.w = 20; // the width of the rectangle in pixels
tabbleR.x = width - tabbleR.w;// upper left corner
tabbleR.y = height / 2 - (tabbleR.h / 2); // upper left corner
tabbleR.speedmin = -3;
tabbleR.speedplus = 3;


  tabbleR.drawTabbleR = () => {
  context.beginPath();
  context.fillRect(tabbleR.x, tabbleR.y, tabbleR.w, tabbleR.h);
  context.closePath();
  context.fill();
}


 tabbleR.updateTabbleR = () => {
  if (tabbleR.y + tabbleR.h / 2 > ball.y) {
    tabbleR.speed = tabbleR.speedmin;
  } else {
    tabbleR.speed = tabbleR.speedplus;
  }
  if (tabbleR.y <= 0 && tabbleR.speed == tabbleR.speedmin) {
    return;
  } else if (tabbleR.y + tabbleR.h >= height && tabbleR.speed == tabbleR.speedplus) {
    return;
  } else {
    tabbleR.y = tabbleR.y + tabbleR.speed;
  }
}
//
// TabbleL (Player)
//
let tabbleL = {};
tabbleL.h = 250; // the height of the rectangle in pixels
tabbleL.w = 20; // the width of the rectangle in pixels
tabbleL.x = 0; // upper left corner
tabbleL.y = height / 2 - (tabbleR.h / 2); // upper left corner

document.addEventListener('mousemove', e => {
  let y = e.pageY - tabbleL.h / 2;
  if (y < 0) {
    tabbleL.y = 0;
    return;
  } else if (y > height - tabbleL.h) {
    tabbleL.y = height - tabbleL.h;
    return;
  }
  tabbleL.y = y;
});

 tabbleL.drawTabbleL = () => {
  context.beginPath();
  context.fillRect(tabbleL.x, tabbleL.y, tabbleL.w, tabbleL.h);
  context.closePath();
  context.fill();
}
//
//game regeling
//
function score() {
  context.font = "50px Arial";
  context.fillText(playerscore + "   |   " + enemyscore, width / 2 - 100, 50);
}
loop();

function loop() {
  context.clearRect(0, 0, width, height);
  //
  ball.updateBall();
  ball.drawBall();

  tabbleR.updateTabbleR();
  tabbleR.drawTabbleR();

  tabbleL.drawTabbleL();

  score();
}

setInterval(loop, 5);
