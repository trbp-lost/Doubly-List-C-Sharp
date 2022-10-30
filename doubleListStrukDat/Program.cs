// Created By Komodo

List<List<double[]>>MyList = new List<List<double[]>>();

double[] data1 = {1, 2, 3};
double[] data2 = {4, 5, 6};
double[] data3 = {7, 8, 9};
double[] data4 = {10, 11, 12};
double[] data5 = {13, 14, 15};

List<double[]> lb1=new List<double[]>();
lb1.Add(data1);
lb1.Add(data2);

List<double[]> lb2=new List<double[]>();
lb2.Add(data3);
lb2.Add(data4);

List<double[]> lb3=new List<double[]>();
lb3.Add(data5);

MyList.Add(lb1);
MyList.Add(lb2);
MyList.Add(lb3);

List<double[]>List1data = new List<double[]>();
List1data = MyList[0];

Console.WriteLine(List1data[1][1]);
Console.WriteLine(MyList[0][1][1]);

double[] RowValues = MyList[0][1]; 
Console.WriteLine(RowValues[2]);