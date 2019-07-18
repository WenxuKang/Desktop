function createTable()
{
var num_rows = document.getElementById('rows').value;
var num_cols = document.getElementById('cols').value;
var theader = '<table border="1">';
var tbody = '';

for( var i=1; i<=num_rows;i++)
{
tbody += '<tr>';
for( var j=1; j<=num_cols;j++)
{
tbody += '<td>';
tbody += i + ',' + j;
tbody += '</td>'
}
tbody += '</tr>';
}
var tfooter = '</table>';
document.getElementById('table').innerHTML = theader + tbody + tfooter;
}