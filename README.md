# WebAPITest_GZIP
WebAPI foi desenvolvida para testar compressão de respostas Json utilizando GZIP.

Uma forma simples que encontrei para fazer a compactação de respostas no ASP.NET MVC, foi através do override do método OnActionExecuted disponibilizado pela 
classe abstrata ActionFilterAttribute, onde capturo os bytes e faço a compressão utilizando o package <strong>DotNetZip 1.16.0</strong>

![image](https://user-images.githubusercontent.com/34588750/161461897-64be41b9-96e6-4f96-a715-eb6812bba9c9.png)


<h1>Como Utilizar ? </h1>

<p>Basicamente é necessario apenas declarar o GzipCompressionFilter na assinatura da Action, muito facil!</p>

![image](https://user-images.githubusercontent.com/34588750/161462621-05483507-de64-4b9d-aa03-6953d6176225.png)


