import random
#import PySimpleGUI as sg

def file_creator(size,filename):
	symbols = ('a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','1','2','3','4','5','6','7','8','9','@','#','№','!','$',';','*','<','>','~','&','?',':','#','$','#','$','%','%','%','@','@','@','@','@')
	file = open(filename, 'w')
	#print("HUI")
	#print(len(symbols))
	for i in range(size * 1000):
		symbol_rand = random.randint(1, len(symbols) - 1)
		#print(symbol_rand)
		file.write(symbols[symbol_rand])
		if i % 150 == 0 and i > 10:
			file.write('\n')
	
	file.close()
	print("Your file succesfully generated")


def main():
 #layout = [
    #[sg.Text('Input'), sg.InputText('Filename'),sg.InputText('Filesize')
     #],
    #[sg.Output(size=(88, 20))],
   #[sg.Submit(), sg.Cancel()]
 #]
 print("Input the size of file you want")
 size = int(input())
 print("Input the name of your file and it's format like 'filename.txt' ")
 filename = input()
 file_creator(size ,filename);
 #window = sg.Window('File Compare', layout)
 #while True:
  #event, values = window.read()
  #print("Input the size of file you want")
  #print("Input the name of your file and it's format like 'filename.txt' ")
  #if event in (None, 'Exit', 'Cancel'):
   #break
  #if event == 'Submit':
   #size = values[1]
   #print(size)
  #filename = values[0]
  #window.close()
if __name__ == "__main__":
	main()

