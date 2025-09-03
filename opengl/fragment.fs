#version 330 core
out vec4 FragColor;
in vec3 aVertexColor;
void main()
{
   FragColor = vec4(aVertexColor, 1.0f);
};