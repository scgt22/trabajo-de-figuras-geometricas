@page
@{
    double lado1 = 3;
    double lado2 = 4;
    double lado3 = 5;
    double baseTriangulo = 3;
    double alturaTriangulo = 4;

    double perimetroTriangulo = Application.Triangulo.Perimetro(lado1, lado2, lado3);
    double areaTriangulo = Application.Triangulo.Area(baseTriangulo, alturaTriangulo);
}

<p>El perímetro de un triángulo con lados de @lado1 cm, @lado2 cm y @lado3 cm es @perimetroTriangulo cm</p>
<p>El área de un triángulo con base de @baseTriangulo cm y altura de @alturaTriangulo cm es @areaTriangulo cm²</p>

