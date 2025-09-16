#version 330 core
out vec4 FragColor;
in vec3 aVertexColor;
in vec2 TexCoords;

uniform sampler2D texture1;
uniform sampler2D texture2;
uniform float mixParameter;

void main()
{
   FragColor = mix(texture(texture1, TexCoords), texture(texture2, TexCoords), mixParameter);
   // Below Line Mix a texel with a color to generate the final pixel
   //FragColor = texture(texture1, TexCoords) * vec4(aVertexColor, 1.0);
};