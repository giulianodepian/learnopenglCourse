#version 330 core
out vec4 FragColor;
in vec3 aVertexPos;
void main()
{
   FragColor = vec4(aVertexPos, 1.0f);
};