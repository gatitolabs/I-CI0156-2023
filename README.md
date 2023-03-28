<a name="readme-top"></a>
<div align="center">
  <h3 align="center">Código I CI0156 2023 UCR</h3>
</div> 

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#quiz"Solución del Quiz</a> </li>
    <li><a href="#angular">Angular + Firebase</a></li>
    <li><a href="#solid">SOLID</a></li>
    <li><a href="#docker">Docker</a></li>
    <li><a href="#gitActions">Git Actions + Azure</a></li>
    <li><a href="#semanticKernel">Semantic Kernel</a></li>
  </ol>
</details>

<!-- Solución del QUiz -->
## Quiz 
Name: QuizSolution<br/> 
Commands: 

dotnet new sln <br/> 
dotnet new classlib -o Model<br/> 
dotnet sln add Model/Model.csproj <br/> 

dotnet new console -o Console<br/> 
dotnet sln add Console/Console.csproj<br/> 
dotnet add Console/Console.csproj reference  Model/Model.csproj <br/> 

dotnet run --project Console/Console.csproj<br/> 

dotnet new -l <br/> 

dotnet new webapp -o WebSite<br/> 
dotnet sln add WebSite/WebSite.csproj <br/> 
dotnet run --project WebSite/WebSite.csproj<br/> 

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Angular + Firebase -->
## Angular
<h5>NO SQL Features</h5> 
Tipos de datos especiales <br/> 
Geopint: una coordenada (longitud/latitud)<br/> 
Map: Es como un Hashmap o un objecto en JS, empotrado dentro del documento <br/> 
Array: Lista de valores ordenados, empotrado dentro del documento <br/> 

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- SOLID -->
## Solid
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Docker -->
## Docker
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Git Actions + Azure -->
## GitActions
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Semantic-Kernel -->
## SemanticKernel
<p align="right">(<a href="#readme-top">back to top</a>)</p>
