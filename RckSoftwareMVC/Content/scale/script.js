const soundButton1 = document.querySelector('#soundButton1'),
  soundButton2 = document.querySelector('#soundButton2'),
  soundButton3 = document.querySelector('#soundButton3'),
  soundButton4 = document.querySelector('#soundButton4');

const stopButton1 = document.querySelector('#stopButton1'),
  stopButton2 = document.querySelector('#stopButton2'),
  stopButton3 = document.querySelector('#stopButton3'),
  stopButton4 = document.querySelector('#stopButton4'),
  stopButton5 = document.querySelector('#stopButton5'),
  stopButton6 = document.querySelector('#stopButton6'),
  stopButton7 = document.querySelector('#stopButton7');
  stopButton8 = document.querySelector('#stopButton8');
  
const stopButtonp1 = document.querySelector('#stopButtonp1'),
  stopButtonp2 = document.querySelector('#stopButtonp2'),
  stopButtonp3 = document.querySelector('#stopButtonp3'),
  stopButtonp4 = document.querySelector('#stopButtonp4'),
  stopButtonp5 = document.querySelector('#stopButtonp5'),
  stopButtonp6 = document.querySelector('#stopButtonp6'),
  stopButtonp7 = document.querySelector('#stopButtonp7')
  stopButtonp8 = document.querySelector('#stopButtonp8');
  
const c4 = 261.6,
	d4 = 293.7,
  e4 = 329.6,
  f4 = 349.2,
  g4 = 392.0,
  a4 = 440.0,
  b4 = 493.9
  c5 = 523.3;

const cp4 = 264.3,
	dp4 = 297.3,
  ep4 = 330.0,
  fp4 = 352.4,
  gp4 = 396.4,
  ap4 = 440.0,
  bp4 = 495.0
  cp5 = 528.6;

  	
let context,
	oscillator,
  contextGain,
  x = 5,
  type = 'sine',
  frequency;
  
function dispose(){
	context=null;
	oscillator=null;
	contextGain=null;
}

function start(){
	context = new AudioContext();
	oscillator = context.createOscillator();
  contextGain = context.createGain();
  oscillator.frequency.value = frequency;
  oscillator.type = type;
  oscillator.connect(contextGain);
	contextGain.connect(context.destination);
	oscillator.start(0);
}

function stop(){
  start();
  contextGain.gain.exponentialRampToValueAtTime(
  	0.00001, context.currentTime + x
	)
}

soundButton1.addEventListener('click', function(){
	type = 'sine';
  dispose();
});
soundButton2.addEventListener('click', function(){
	type = 'square';
  dispose();
});
soundButton3.addEventListener('click', function(){
	type = 'triangle';
  dispose();
});
soundButton4.addEventListener('click', function(){
	type = 'sawtooth';
  dispose();
});

stopButton1.addEventListener('click', function(){
	frequency = c4;
  stop();
});
stopButton2.addEventListener('click', function(){
	frequency = d4;
  stop();
});
stopButton3.addEventListener('click', function(){
	frequency = e4;
  stop();
});
stopButton4.addEventListener('click', function(){
	frequency = f4;
  stop();
});
stopButton5.addEventListener('click', function(){
	frequency = g4;
  stop();
});
stopButton6.addEventListener('click', function(){
	frequency = a4;
  stop();
});
stopButton7.addEventListener('click', function(){
	frequency = b4;
  stop();
});
stopButton8.addEventListener('click', function(){
	frequency = c5;
  stop();
});

stopButtonp1.addEventListener('click', function(){
	frequency = cp4;
  stop();
});
stopButtonp2.addEventListener('click', function(){
	frequency = dp4;
  stop();
});
stopButtonp3.addEventListener('click', function(){
	frequency = ep4;
  stop();
});
stopButtonp4.addEventListener('click', function(){
	frequency = fp4;
  stop();
});
stopButtonp5.addEventListener('click', function(){
	frequency = gp4;
  stop();
});
stopButtonp6.addEventListener('click', function(){
	frequency = ap4;
  stop();
});
stopButtonp7.addEventListener('click', function(){
	frequency = bp4;
  stop();
});
stopButtonp8.addEventListener('click', function(){
	frequency = cp5;
  stop();
});