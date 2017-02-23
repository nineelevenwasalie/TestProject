//convert these for loops to while loops
//1
for(int i=0;i<10;i=i+1){
	Console.WriteLine("Hello World");
}
//2
for(int i=3;i<13;i=i+1){
	Console.WriteLine("Hello World");
}
//3
for(int i=45;i>10;i=i-1){
	Console.WriteLine("Hello World");
}
//4
for(int i=25;i>=10;i=i-3){
	Console.WriteLine("Hello World");
}
//5
for(int i=2;i<128;i=i+i){
	Console.WriteLine("Hello World");
}
//6
for(int i=1;i<50;i=i*3){
	Console.WriteLine("Hello World");
}
//7
int j = 0;
for(int i=10;i<13;j=j+1){
	if (j == 7){
		i = i+1;
		j = 0;
	}
	Console.WriteLine("Hello World");
}
//8
for(int i=0;i<10;i=i+2){
	if (i > 5){
		i = i-1;
	}
	Console.WriteLine("Hello World");
}
//9
for(int i=0;i<60;i=i+1){
	for(int j=0;j<60;j=j+1){
		for(int k=0;k<60;k=k+1){
			Console.WriteLine("Hello World");
		}
	}
}
//10
for(int i=0;i<60;i=i+1){
	for(int j=0;j<60;j=j+1){
		Console.WriteLine("Hello World");
		if (j>30){
			i = i+1;
		}
	}
}
