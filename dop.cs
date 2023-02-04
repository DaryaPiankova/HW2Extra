using System.IO;

string content = File.ReadAllText("input.txt");
                
                
int ScndMax = (int)Char.GetNumericValue(content[0]);
int firstMax = (int)Char.GetNumericValue(content[0]);

for(int i=0; i<content.Length; i++){
    if((int)Char.GetNumericValue(content[i])>firstMax){
        firstMax=(int)Char.GetNumericValue(content[i]);
    }
}
for(int j=0; j<content.Length; j++){
    if((int)Char.GetNumericValue(content[j])!=firstMax){
        if((int)Char.GetNumericValue(content[j])>ScndMax){
        ScndMax=(int)Char.GetNumericValue(content[j]);
        }
    }
}
StreamWriter sw = new StreamWriter("output.txt");
sw.WriteLine(ScndMax); 
sw.Close();