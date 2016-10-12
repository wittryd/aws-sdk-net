/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DataPipeline.Model;

namespace Amazon.DataPipeline
{
    /// <summary>
    /// Interface for accessing DataPipeline
    ///
    /// AWS Data Pipeline configures and manages a data-driven workflow called a pipeline.
    /// AWS Data Pipeline handles the details of scheduling and ensuring that data dependencies
    /// are met so that your application can focus on processing the data.
    /// 
    ///  
    /// <para>
    /// AWS Data Pipeline provides a JAR implementation of a task runner called AWS Data Pipeline
    /// Task Runner. AWS Data Pipeline Task Runner provides logic for common data management
    /// scenarios, such as performing database queries and running data analysis using Amazon
    /// Elastic MapReduce (Amazon EMR). You can use AWS Data Pipeline Task Runner as your
    /// task runner, or you can write your own task runner to provide custom data management.
    /// </para>
    ///  
    /// <para>
    /// AWS Data Pipeline implements two main sets of functionality. Use the first set to
    /// create a pipeline and define data sources, schedules, dependencies, and the transforms
    /// to be performed on the data. Use the second set in your task runner application to
    /// receive the next task ready for processing. The logic for performing the task, such
    /// as querying the data, running data analysis, or converting the data from one format
    /// to another, is contained within the task runner. The task runner performs the task
    /// assigned to it by the web service, reporting progress to the web service as it does
    /// so. When the task is done, the task runner reports the final success or failure of
    /// the task to the web service.
    /// </para>
    /// </summary>
    public partial interface IAmazonDataPipeline : IAmazonService, IDisposable
    {

        
        #region  ActivatePipeline


        /// <summary>
        /// Validates the specified pipeline and starts processing pipeline tasks. If the pipeline
        /// does not pass validation, activation fails.
        /// 
        ///  
        /// <para>
        /// If you need to pause the pipeline to investigate an issue with a component, such as
        /// a data source or script, call <a>DeactivatePipeline</a>.
        /// </para>
        ///  
        /// <para>
        /// To activate a finished pipeline, modify the end date for the pipeline and then activate
        /// it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline service method.</param>
        /// 
        /// <returns>The response from the ActivatePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        ActivatePipelineResponse ActivatePipeline(ActivatePipelineRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ActivatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ActivatePipelineResponse> ActivatePipelineAsync(ActivatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddTags


        /// <summary>
        /// Adds or modifies tags for the specified pipeline.
        /// </summary>
        /// <param name="pipelineId">The ID of the pipeline.</param>
        /// <param name="tags">The tags to add, as key/value pairs.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        AddTagsResponse AddTags(string pipelineId, List<Tag> tags);

        /// <summary>
        /// Adds or modifies tags for the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        AddTagsResponse AddTags(AddTagsRequest request);


        /// <summary>
        /// Adds or modifies tags for the specified pipeline.
        /// </summary>
        /// <param name="pipelineId">The ID of the pipeline.</param>
        /// <param name="tags">The tags to add, as key/value pairs.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        Task<AddTagsResponse> AddTagsAsync(string pipelineId, List<Tag> tags, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// Creates a new, empty pipeline. Use <a>PutPipelineDefinition</a> to populate the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeactivatePipeline


        /// <summary>
        /// Deactivates the specified running pipeline. The pipeline is set to the <code>DEACTIVATING</code>
        /// state until the deactivation process completes.
        /// 
        ///  
        /// <para>
        /// To resume a deactivated pipeline, use <a>ActivatePipeline</a>. By default, the pipeline
        /// resumes from the last completed execution. Optionally, you can specify the date and
        /// time to resume the pipeline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivatePipeline service method.</param>
        /// 
        /// <returns>The response from the DeactivatePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        DeactivatePipelineResponse DeactivatePipeline(DeactivatePipelineRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeactivatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeactivatePipelineResponse> DeactivatePipelineAsync(DeactivatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// Deletes a pipeline, its pipeline definition, and its run history. AWS Data Pipeline
        /// attempts to cancel instances associated with the pipeline that are currently being
        /// processed by task runners.
        /// 
        ///  
        /// <para>
        /// Deleting a pipeline cannot be undone. You cannot query or restore a deleted pipeline.
        /// To temporarily pause a pipeline instead of deleting it, call <a>SetStatus</a> with
        /// the status set to <code>PAUSE</code> on individual components. Components that are
        /// paused by <a>SetStatus</a> can be resumed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeObjects


        /// <summary>
        /// Gets the object definitions for a set of objects associated with the pipeline. Object
        /// definitions are composed of a set of fields that define the properties of the object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects service method.</param>
        /// 
        /// <returns>The response from the DescribeObjects service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        DescribeObjectsResponse DescribeObjects(DescribeObjectsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeObjectsResponse> DescribeObjectsAsync(DescribeObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePipelines


        /// <summary>
        /// Retrieves metadata about one or more pipelines. The information retrieved includes
        /// the name of the pipeline, the pipeline identifier, its current state, and the user
        /// account that owns the pipeline. Using account credentials, you can retrieve metadata
        /// about pipelines that you or your IAM users have created. If you are using an IAM user
        /// account, you can retrieve metadata about only those pipelines for which you have read
        /// permissions.
        /// 
        ///  
        /// <para>
        /// To retrieve the full pipeline definition instead of metadata about the pipeline, call
        /// <a>GetPipelineDefinition</a>.
        /// </para>
        /// </summary>
        /// <param name="pipelineIds">The IDs of the pipelines to describe. You can pass as many as 25 identifiers in a single call. To obtain pipeline IDs, call <a>ListPipelines</a>.</param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        DescribePipelinesResponse DescribePipelines(List<string> pipelineIds);

        /// <summary>
        /// Retrieves metadata about one or more pipelines. The information retrieved includes
        /// the name of the pipeline, the pipeline identifier, its current state, and the user
        /// account that owns the pipeline. Using account credentials, you can retrieve metadata
        /// about pipelines that you or your IAM users have created. If you are using an IAM user
        /// account, you can retrieve metadata about only those pipelines for which you have read
        /// permissions.
        /// 
        ///  
        /// <para>
        /// To retrieve the full pipeline definition instead of metadata about the pipeline, call
        /// <a>GetPipelineDefinition</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines service method.</param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        DescribePipelinesResponse DescribePipelines(DescribePipelinesRequest request);


        /// <summary>
        /// Retrieves metadata about one or more pipelines. The information retrieved includes
        /// the name of the pipeline, the pipeline identifier, its current state, and the user
        /// account that owns the pipeline. Using account credentials, you can retrieve metadata
        /// about pipelines that you or your IAM users have created. If you are using an IAM user
        /// account, you can retrieve metadata about only those pipelines for which you have read
        /// permissions.
        /// 
        ///  
        /// <para>
        /// To retrieve the full pipeline definition instead of metadata about the pipeline, call
        /// <a>GetPipelineDefinition</a>.
        /// </para>
        /// </summary>
        /// <param name="pipelineIds">The IDs of the pipelines to describe. You can pass as many as 25 identifiers in a single call. To obtain pipeline IDs, call <a>ListPipelines</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        Task<DescribePipelinesResponse> DescribePipelinesAsync(List<string> pipelineIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePipelinesResponse> DescribePipelinesAsync(DescribePipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EvaluateExpression


        /// <summary>
        /// Task runners call <code>EvaluateExpression</code> to evaluate a string in the context
        /// of the specified object. For example, a task runner can evaluate SQL queries stored
        /// in Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression service method.</param>
        /// 
        /// <returns>The response from the EvaluateExpression service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        EvaluateExpressionResponse EvaluateExpression(EvaluateExpressionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EvaluateExpressionResponse> EvaluateExpressionAsync(EvaluateExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPipelineDefinition


        /// <summary>
        /// Gets the definition of the specified pipeline. You can call <code>GetPipelineDefinition</code>
        /// to retrieve the pipeline definition that you provided using <a>PutPipelineDefinition</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition service method.</param>
        /// 
        /// <returns>The response from the GetPipelineDefinition service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        GetPipelineDefinitionResponse GetPipelineDefinition(GetPipelineDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetPipelineDefinitionResponse> GetPipelineDefinitionAsync(GetPipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// Lists the pipeline identifiers for all active pipelines that you have permission to
        /// access.
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        ListPipelinesResponse ListPipelines();


        /// <summary>
        /// Lists the pipeline identifiers for all active pipelines that you have permission to
        /// access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        ListPipelinesResponse ListPipelines(ListPipelinesRequest request);


        /// <summary>
        /// Lists the pipeline identifiers for all active pipelines that you have permission to
        /// access.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        Task<ListPipelinesResponse> ListPipelinesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PollForTask


        /// <summary>
        /// Task runners call <code>PollForTask</code> to receive a task to perform from AWS Data
        /// Pipeline. The task runner specifies which tasks it can perform by setting a value
        /// for the <code>workerGroup</code> parameter. The task returned can come from any of
        /// the pipelines that match the <code>workerGroup</code> value passed in by the task
        /// runner and that was launched using the IAM user credentials specified by the task
        /// runner.
        /// 
        ///  
        /// <para>
        /// If tasks are ready in the work queue, <code>PollForTask</code> returns a response
        /// immediately. If no tasks are available in the queue, <code>PollForTask</code> uses
        /// long-polling and holds on to a poll connection for up to a 90 seconds, during which
        /// time the first newly scheduled task is handed to the task runner. To accomodate this,
        /// set the socket timeout in your task runner to 90 seconds. The task runner should not
        /// call <code>PollForTask</code> again on the same <code>workerGroup</code> until it
        /// receives a response, and this can take up to 90 seconds. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForTask service method.</param>
        /// 
        /// <returns>The response from the PollForTask service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        PollForTaskResponse PollForTask(PollForTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PollForTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PollForTaskResponse> PollForTaskAsync(PollForTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPipelineDefinition


        /// <summary>
        /// Adds tasks, schedules, and preconditions to the specified pipeline. You can use <code>PutPipelineDefinition</code>
        /// to populate a new pipeline.
        /// 
        ///  
        /// <para>
        ///  <code>PutPipelineDefinition</code> also validates the configuration as it adds it
        /// to the pipeline. Changes to the pipeline are saved unless one of the following three
        /// validation errors exists in the pipeline. 
        /// </para>
        ///  <ol> <li>An object is missing a name or identifier field.</li> <li>A string or reference
        /// field is empty.</li> <li>The number of objects in the pipeline exceeds the maximum
        /// allowed objects.</li> <li>The pipeline is in a FINISHED state.</li> </ol> 
        /// <para>
        ///  Pipeline object definitions are passed to the <code>PutPipelineDefinition</code>
        /// action and returned by the <a>GetPipelineDefinition</a> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition service method.</param>
        /// 
        /// <returns>The response from the PutPipelineDefinition service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        PutPipelineDefinitionResponse PutPipelineDefinition(PutPipelineDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutPipelineDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutPipelineDefinitionResponse> PutPipelineDefinitionAsync(PutPipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  QueryObjects


        /// <summary>
        /// Queries the specified pipeline for the names of objects that match the specified set
        /// of conditions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects service method.</param>
        /// 
        /// <returns>The response from the QueryObjects service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        QueryObjectsResponse QueryObjects(QueryObjectsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the QueryObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<QueryObjectsResponse> QueryObjectsAsync(QueryObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes existing tags from the specified pipeline.
        /// </summary>
        /// <param name="pipelineId">The ID of the pipeline.</param>
        /// <param name="tagKeys">The keys of the tags to remove.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        RemoveTagsResponse RemoveTags(string pipelineId, List<string> tagKeys);

        /// <summary>
        /// Removes existing tags from the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);


        /// <summary>
        /// Removes existing tags from the specified pipeline.
        /// </summary>
        /// <param name="pipelineId">The ID of the pipeline.</param>
        /// <param name="tagKeys">The keys of the tags to remove.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        Task<RemoveTagsResponse> RemoveTagsAsync(string pipelineId, List<string> tagKeys, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReportTaskProgress


        /// <summary>
        /// Task runners call <code>ReportTaskProgress</code> when assigned a task to acknowledge
        /// that it has the task. If the web service does not receive this acknowledgement within
        /// 2 minutes, it assigns the task in a subsequent <a>PollForTask</a> call. After this
        /// initial acknowledgement, the task runner only needs to report progress every 15 minutes
        /// to maintain its ownership of the task. You can change this reporting time from 15
        /// minutes by specifying a <code>reportProgressTimeout</code> field in your pipeline.
        /// 
        ///  
        /// <para>
        /// If a task runner does not report its status after 5 minutes, AWS Data Pipeline assumes
        /// that the task runner is unable to process the task and reassigns the task in a subsequent
        /// response to <a>PollForTask</a>. Task runners should call <code>ReportTaskProgress</code>
        /// every 60 seconds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress service method.</param>
        /// 
        /// <returns>The response from the ReportTaskProgress service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        ReportTaskProgressResponse ReportTaskProgress(ReportTaskProgressRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskProgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReportTaskRunnerHeartbeat


        /// <summary>
        /// Task runners call <code>ReportTaskRunnerHeartbeat</code> every 15 minutes to indicate
        /// that they are operational. If the AWS Data Pipeline Task Runner is launched on a resource
        /// managed by AWS Data Pipeline, the web service can use this call to detect when the
        /// task runner application has failed and restart a new instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat service method.</param>
        /// 
        /// <returns>The response from the ReportTaskRunnerHeartbeat service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        ReportTaskRunnerHeartbeatResponse ReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskRunnerHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReportTaskRunnerHeartbeatResponse> ReportTaskRunnerHeartbeatAsync(ReportTaskRunnerHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetStatus


        /// <summary>
        /// Requests that the status of the specified physical or logical pipeline objects be
        /// updated in the specified pipeline. This update might not occur immediately, but is
        /// eventually consistent. The status that can be set depends on the type of object (for
        /// example, DataNode or Activity). You cannot perform this operation on <code>FINISHED</code>
        /// pipelines and attempting to do so returns <code>InvalidRequestException</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStatus service method.</param>
        /// 
        /// <returns>The response from the SetStatus service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        SetStatusResponse SetStatus(SetStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetStatusResponse> SetStatusAsync(SetStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetTaskStatus


        /// <summary>
        /// Task runners call <code>SetTaskStatus</code> to notify AWS Data Pipeline that a task
        /// is completed and provide information about the final status. A task runner makes this
        /// call regardless of whether the task was sucessful. A task runner does not need to
        /// call <code>SetTaskStatus</code> for tasks that are canceled by the web service during
        /// a call to <a>ReportTaskProgress</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus service method.</param>
        /// 
        /// <returns>The response from the SetTaskStatus service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        SetTaskStatusResponse SetTaskStatus(SetTaskStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetTaskStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetTaskStatusResponse> SetTaskStatusAsync(SetTaskStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ValidatePipelineDefinition


        /// <summary>
        /// Validates the specified pipeline definition to ensure that it is well formed and can
        /// be run without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition service method.</param>
        /// 
        /// <returns>The response from the ValidatePipelineDefinition service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        ValidatePipelineDefinitionResponse ValidatePipelineDefinition(ValidatePipelineDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePipelineDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ValidatePipelineDefinitionResponse> ValidatePipelineDefinitionAsync(ValidatePipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}