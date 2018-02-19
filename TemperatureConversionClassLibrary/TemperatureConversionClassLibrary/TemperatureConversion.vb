Public Class TemperatureConversion

    Property temperature As Double

        Public Sub New(temperature As Double)
            Me.temperature = temperature
        End Sub

        Public Function FarenheitToCelcius() As Double
            Dim convertedTemp As Double

        convertedTemp = Math.Round(((Me.temperature - 32) / 1.8), 2)
        Return convertedTemp
        End Function

        Public Function CelciusToFarenheit() As Double
            Dim convertedTemp As Double

        convertedTemp = Math.Round((Me.temperature * 1.8 + 32), 2)
        Return convertedTemp
        End Function

End Class
