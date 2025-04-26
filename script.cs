{
  "createOrReplace": {
    "object": {
      "database": "03b6f587-0b95-4fdd-bdbe-5743a8c6bd7e",
      "table": "Sales"
    },
    "table": {
      "name": "Sales",
      "lineageTag": "94d3ea3b-4449-4e27-903d-c961f1df5413",
      "columns": [
        {
          "name": "Order Number",
          "dataType": "int64",
          "isHidden": true,
          "sourceColumn": "Order Number",
          "formatString": "0",
          "lineageTag": "91ea6a29-4cac-4426-9100-5736937552bf",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "User"
            }
          ]
        },
        {
          "name": "Line Number",
          "dataType": "int64",
          "isHidden": true,
          "sourceColumn": "Line Number",
          "formatString": "0",
          "lineageTag": "45bd733b-90c9-4ecc-93d6-37528e2e27b4",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "User"
            }
          ]
        },
        {
          "name": "Order Date",
          "dataType": "dateTime",
          "isHidden": true,
          "sourceColumn": "Order Date",
          "formatString": "mm/dd/yyyy",
          "lineageTag": "64b1d016-32bc-4c20-80d7-a5adc3b9ae88",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            },
            {
              "property": "FormatString"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "Automatic"
            },
            {
              "name": "UnderlyingDateTimeDataType",
              "value": "Date"
            },
            {
              "name": "PBI_FormatHint",
              "value": "{\"isDateTimeCustom\":true}"
            }
          ]
        },
        {
          "name": "Delivery Date",
          "dataType": "dateTime",
          "isHidden": true,
          "sourceColumn": "Delivery Date",
          "formatString": "mm/dd/yyyy",
          "lineageTag": "fb541e07-fdfb-40c9-9166-29777f049df4",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            },
            {
              "property": "FormatString"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "Automatic"
            },
            {
              "name": "UnderlyingDateTimeDataType",
              "value": "Date"
            },
            {
              "name": "PBI_FormatHint",
              "value": "{\"isDateTimeCustom\":true}"
            }
          ]
        },
        {
          "name": "CustomerKey",
          "dataType": "int64",
          "isHidden": true,
          "sourceColumn": "CustomerKey",
          "formatString": "0",
          "lineageTag": "b35afdc7-615a-4e88-8c36-36c10285f310",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "Automatic"
            }
          ]
        },
        {
          "name": "StoreKey",
          "dataType": "int64",
          "isHidden": true,
          "sourceColumn": "StoreKey",
          "formatString": "0",
          "lineageTag": "f917bacb-2013-409d-9d94-8b40068bc9a7",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "Automatic"
            }
          ]
        },
        {
          "name": "ProductKey",
          "dataType": "int64",
          "isHidden": true,
          "sourceColumn": "ProductKey",
          "formatString": "0",
          "lineageTag": "f011ea83-0d14-41e5-a9f2-8d532338586f",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "Automatic"
            }
          ]
        },
        {
          "name": "Quantity",
          "dataType": "int64",
          "isHidden": true,
          "sourceColumn": "Quantity",
          "formatString": "0",
          "lineageTag": "c8ca10d3-f54d-4c5d-b5ef-da854e2d7973",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "User"
            }
          ]
        },
        {
          "name": "Unit Price",
          "dataType": "decimal",
          "isHidden": true,
          "sourceColumn": "Unit Price",
          "formatString": "#,0.00",
          "lineageTag": "8c2ee660-1f97-48df-a30b-9e6818ed5be9",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            },
            {
              "property": "FormatString"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "User"
            }
          ]
        },
        {
          "name": "Net Price",
          "dataType": "decimal",
          "isHidden": true,
          "sourceColumn": "Net Price",
          "formatString": "#,0.00",
          "lineageTag": "690e56a1-1bb6-4aa8-83bc-2b81fa8e4bf7",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            },
            {
              "property": "FormatString"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "User"
            }
          ]
        },
        {
          "name": "Unit Cost",
          "dataType": "decimal",
          "isHidden": true,
          "sourceColumn": "Unit Cost",
          "formatString": "#,0.00",
          "lineageTag": "07c65c15-9e35-47c1-bbab-9cca274818c7",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            },
            {
              "property": "FormatString"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "User"
            }
          ]
        },
        {
          "name": "Currency Code",
          "dataType": "string",
          "isHidden": true,
          "sourceColumn": "Currency Code",
          "lineageTag": "af1aa82f-8a7e-4d57-9da8-8d64994488a5",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "Automatic"
            }
          ]
        },
        {
          "name": "Exchange Rate",
          "dataType": "double",
          "isHidden": true,
          "sourceColumn": "Exchange Rate",
          "formatString": "0.0000",
          "lineageTag": "7ddca17e-170a-4c4d-aa29-37f19394e838",
          "summarizeBy": "none",
          "changedProperties": [
            {
              "property": "IsHidden"
            },
            {
              "property": "FormatString"
            }
          ],
          "annotations": [
            {
              "name": "SummarizationSetBy",
              "value": "User"
            }
          ]
        }
      ],
      "partitions": [
        {
          "name": "Sales-4929449f-be0b-48cf-a44e-c644698415ba",
          "mode": "import",
          "source": {
            "type": "m",
            "expression": [
              "let",
              "    Source = Sql.Databases(\"Demo\"),",
              "    #\"Contoso\" = Source{[Name=\"Contoso V2 10K\"]}[Data],",
              "    dbo_Sales = #\"Contoso\"{[Schema=\"dbo\",Item=\"Sales\"]}[Data],",
              "    #\"Changed Type\" = Table.TransformColumnTypes(dbo_Sales,{{\"Unit Cost\", Currency.Type}, {\"Net Price\", Currency.Type}, {\"Unit Price\", Currency.Type}, {\"Quantity\", Int64.Type}})",
              "in",
              "    #\"Changed Type\""
            ]
          }
        }
      ],
      "measures": [
        {
          "name": "Sales Amount",
          "expression": "SUMX ( Sales, Sales[Quantity] * Sales[Net Price] )",
          "formatString": "#,0.00",
          "lineageTag": "7c5f9a14-3465-43ab-b1e5-aeb03f4fe8ad",
          "changedProperties": [
            {
              "property": "FormatString"
            },
            {
              "property": "IsHidden"
            }
          ]
        },
        {
          "name": "Total Cost",
          "expression": "SUMX ( Sales, Sales[Quantity] * Sales[Unit Cost] )",
          "formatString": "#,0.00",
          "lineageTag": "416604ca-8ec2-48fb-97e3-568ef1a0c264",
          "changedProperties": [
            {
              "property": "FormatString"
            },
            {
              "property": "IsHidden"
            }
          ]
        },
        {
          "name": "Margin",
          "expression": "[Sales Amount] - [Total Cost]",
          "formatString": "#,0.00",
          "lineageTag": "e22dbc08-3844-485a-96d6-625d9d77e004",
          "changedProperties": [
            {
              "property": "FormatString"
            },
            {
              "property": "IsHidden"
            }
          ]
        },
        {
          "name": "Margin %",
          "expression": "DIVIDE ( [Margin], [Sales Amount] )",
          "formatString": "0.00%;-0.00%;0.00%",
          "lineageTag": "78f2291d-1076-4202-b7bc-8d5dcd28f612",
          "changedProperties": [
            {
              "property": "FormatString"
            },
            {
              "property": "IsHidden"
            }
          ]
        },
        {
          "name": "Total Quantity",
          "expression": "SUM ( Sales[Quantity] )",
          "formatString": "#,0",
          "lineageTag": "3c59d762-8e5b-4258-a132-1b6983b435ce",
          "changedProperties": [
            {
              "property": "FormatString"
            },
            {
              "property": "IsHidden"
            }
          ]
        },
        {
          "name": "Pareto Cumulative",
          "expression": [
            "",
            "VAR x_pos = SELECTEDVALUE ( X_axis[X] )",
            "VAR points =",
            "    ADDCOLUMNS (",
            "        VALUES ( Customer[CustomerKey] ),",
            "        \"@Value\", [Metric Value]",
            "    )",
            "VAR cumulated_points =",
            "    WINDOW (",
            "        1, ABS,",
            "        x_pos, ABS,",
            "        points,",
            "        ORDERBY ( [@Value], DESC, Customer[CustomerKey], ASC )",
            "    )",
            "VAR Result = ",
            "    SUMX ( ",
            "        cumulated_points, ",
            "        [@Value] ",
            "    )",
            "RETURN",
            "    Result",
            ""
          ],
          "formatString": "#,0.00",
          "lineageTag": "497b2ea5-f3be-4dba-bd1d-a08c16ad1f7b"
        },
        {
          "name": "Pareto Amount",
          "expression": [
            "",
            "VAR x_pos = SELECTEDVALUE ( X_axis[X] )",
            "VAR points =",
            "    ADDCOLUMNS (",
            "        VALUES ( Customer[CustomerKey] ),",
            "        \"@Value\", [Metric Value]",
            "    )",
            "VAR selected_point =",
            "    WINDOW (",
            "        x_pos, ABS,",
            "        x_pos, ABS,",
            "        points,",
            "        ORDERBY ( [@Value], DESC, Customer[CustomerKey], ASC )",
            "    )",
            "VAR Result = ",
            "    SELECTCOLUMNS ( ",
            "        selected_point, ",
            "        [@Value] ",
            "    )",
            "RETURN",
            "    Result"
          ],
          "formatString": "#,0.00",
          "lineageTag": "7726f43b-4a4b-45d9-9b19-9bb89356bcb9"
        },
        {
          "name": "Pareto %",
          "expression": [
            "",
            "DIVIDE ( [Pareto Cumulative], [Metric Value] )"
          ],
          "formatString": "0.00%;-0.00%;0.00%",
          "lineageTag": "650fdda2-6162-4f19-81ae-5a244db433f2"
        },
        {
          "name": "Metric Value",
          "expression": [
            "",
            "SWITCH (",
            "    SELECTEDVALUE ( Metric[Measure] ),",
            "    \"Margin\", [Margin],",
            "    \"Sales Amount\", [Sales Amount],",
            "    \"Total Cost\", [Total Cost],",
            "    \"Total Quantity\", [Total Quantity],",
            "    ERROR ( \"Measure not selected in Metric[Measure]\" )",
            ")"
          ],
          "formatString": "#,0.00",
          "lineageTag": "4320db0f-1132-4496-a015-e1aa0da385c2"
        },
        {
          "name": "Customer Name",
          "expression": [
            "",
            "VAR x_pos = SELECTEDVALUE ( X_axis[X] )",
            "VAR points =",
            "    ADDCOLUMNS (",
            "        ALLSELECTED ( Customer[CustomerKey], Customer[Name] ),",
            "        \"@Value\", [Metric Value]",
            "    )",
            "VAR selected_point =",
            "    WINDOW (",
            "        x_pos, ABS,",
            "        x_pos, ABS,",
            "        points,",
            "        ORDERBY ( [@Value], DESC, Customer[CustomerKey], ASC )",
            "    )",
            "VAR Result = ",
            "    SELECTCOLUMNS ( ",
            "        selected_point, ",
            "        Customer[Name]",
            "    )",
            "RETURN",
            "    Result",
            ""
          ],
          "lineageTag": "51a4efb5-57b0-4a8d-b035-283c1452ba89"
        },
        {
          "name": "Pareto Classic",
          "expression": [
            "",
            "VAR points =",
            "    ADDCOLUMNS (",
            "        ALLSELECTED ( Customer[Name] ),",
            "        \"@Value\", [Metric Value]",
            "    )",
            "VAR current_value = [Metric Value]",
            "VAR cumulated_points = ",
            "    FILTER (",
            "        points,",
            "        [@Value] >= current_value",
            "    )",
            "VAR Result = ",
            "    SUMX ( ",
            "        cumulated_points, ",
            "        [@Value] ",
            "    )",
            "RETURN",
            "    Result",
            ""
          ],
          "formatString": "#,0.00",
          "lineageTag": "b5e38c82-df22-4cfe-b345-a7e56b0c2168"
        },
        {
          "name": "Pareto Classic %",
          "expression": [
            "",
            "DIVIDE ( [Pareto Classic], CALCULATE ( [Metric Value], ALLSELECTED ( Customer[Name] ) ))"
          ],
          "formatString": "0.00%;-0.00%;0.00%",
          "lineageTag": "8b03d64f-81a2-4e12-9a41-6b1a946dacc8"
        }
      ],
      "annotations": [
        {
          "name": "PBI_ResultType",
          "value": "Table"
        },
        {
          "name": "PBI_NavigationStepName",
          "value": "Navigation"
        }
      ]
    }
  }
}