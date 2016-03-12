
TGT:=mergesort

all:
	fsharpc -o $(TGT).exe $(TGT).fs
	chmod +x $(TGT).exe

run:
	./$(TGT).exe

clean:
	rm *.exe
